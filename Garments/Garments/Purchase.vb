
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class Purchase
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim i As Integer

    Private Sub stuid_TextChanged(sender As Object, e As EventArgs) Handles stuid.TextChanged
        Dim studentID As String = stuid.Text.Trim()
        Dim sqlQuery As String = "SELECT student_fname, student_lname, course, department FROM student WHERE student_id = @studentID"

        stuid.MaxLength = 7

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@studentID", studentID)

        conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            fname.Text = reader.GetString("student_fname")
            lname.Text = reader.GetString("student_lname")
            coursestud.Text = reader.GetString("course")
            dept.Text = reader.GetString("department")
        Else

            fname.Clear()
            lname.Clear()
            coursestud.Clear()
            dept.Clear()
        End If


        reader.Close()
        conn.Close()
    End Sub

    Private Sub pidbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pidbox.SelectedIndexChanged
        Dim productID As String = pidbox.Text.Trim()
        Dim sqlQuery As String = "SELECT product_type, product_size, current_unit_price, product_stocks FROM product WHERE product_id = @productID"

        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@productID", productID)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()

            Dim stockQuantity As Integer = reader.GetInt32("product_stocks")

            If stockQuantity = 0 Then
                reader.Close() ' Close the current DataReader
                MessageBox.Show("This product is currently out of stock.")
                pidbox.SelectedIndex = -1
                pname.Clear()
                prodsize.Clear()
                price.Clear()
            Else
                pname.Text = reader.GetString("product_type")
                prodsize.Text = reader.GetString("product_size")
                price.Text = reader.GetString("current_unit_price")
            End If
        Else
            pname.Clear()
            prodsize.Clear()
            price.Clear()
        End If

        reader.Close()
        conn.Close()
    End Sub





    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
        data_load2()


        pidbox.DropDownStyle = ComboBoxStyle.DropDownList

        Dim str As String = "SELECT product_id FROM product"
        Dim cmd As New MySqlCommand(str, conn)

        Try
            conn.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                pidbox.Items.Add(reader.GetString("product_id"))
            End While

            reader.Close()
        Catch ex As Exception
            ' handle exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If stuid.Text = "" Or pidbox.Text = "" Or prodsize.Text = "" Or prodquant.Text = "" Or price.Text = "" Then
            MsgBox("Please fill in all required fields.")
            Return
        End If
        Dim purchaseNo As Integer = 0
        Dim strGetMaxID As String = "SELECT MAX(purchase_no) FROM purchase"
        Dim strInsert As String = "INSERT INTO purchase (purchase_no, student_id, product_id, date_purchase, prod_name, prod_price, quantity, size, total) " &
            "VALUES (@purchase_no, @student_id, @product_id, @date_purchase, @prod_name, @prod_price, @quantity, @size, @total)"

        Dim quantity As Integer
        If Not Integer.TryParse(prodquant.Text, quantity) Or quantity <= 0 Then
            MsgBox("Invalid product quantity. Please enter a positive integer value.")
            Return
        End If

        Dim studentIdRegex As New Regex("^\d{2}-\d{4}$")
        If Not studentIdRegex.IsMatch(stuid.Text) Then
            MsgBox("Invalid student ID format. Please enter in the format 00-0000.")
            Return
        End If
        Try
            conn.Open()


            ' Get the maximum purchase number and increment by 1
            Dim cmdGetMaxID As New MySqlCommand(strGetMaxID, conn)
            Dim maxID = cmdGetMaxID.ExecuteScalar()
            If Not IsDBNull(maxID) Then
                purchaseNo = CType(maxID, Integer) + 1
            Else
                purchaseNo = 1
            End If

            ' Calculate total and insert the new record with the incremented purchase number and total
            Dim totalPrice As Double = CDec(price.Text) * CDec(prodquant.Text)
            Dim cmdInsert As New MySqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@purchase_no", purchaseNo)
            cmdInsert.Parameters.AddWithValue("@student_id", stuid.Text)
            cmdInsert.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmdInsert.Parameters.AddWithValue("@date_purchase", datepur.Value.ToString("yyyy-MM-dd"))
            cmdInsert.Parameters.AddWithValue("@prod_name", pname.Text)
            cmdInsert.Parameters.AddWithValue("@prod_price", CDec(price.Text))
            cmdInsert.Parameters.AddWithValue("@quantity", prodquant.Text)
            cmdInsert.Parameters.AddWithValue("@size", prodsize.Text)
            cmdInsert.Parameters.AddWithValue("@total", CDec(totalPrice))
            cmdInsert.ExecuteNonQuery()

            ' Get the current stock of the product
            Dim cmdGetStock As New MySqlCommand("SELECT product_stocks FROM product WHERE product_id = @product_id", conn)
            cmdGetStock.Parameters.AddWithValue("@product_id", pidbox.Text)
            Dim currentStock As Integer = CInt(cmdGetStock.ExecuteScalar())

            ' Calculate the new stock after the purchase
            Dim purchasedQuantity As Integer = CInt(prodquant.Text)
            Dim newStock As Integer = currentStock - purchasedQuantity

            ' Update the product table with the new stock
            Dim cmdUpdateStock As New MySqlCommand("UPDATE product SET product_stocks = @product_stocks WHERE product_id = @product_id", conn)
            cmdUpdateStock.Parameters.AddWithValue("@product_stocks", newStock)
            cmdUpdateStock.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmdUpdateStock.ExecuteNonQuery()

            MsgBox("New Record Added")
            Dim Pays As New Pays(stuid.Text, purchaseNo)
            Pays.Show()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

        clear_data()
        data_load()
        data_load2()
    End Sub

    Public Sub data_load()
        data.Rows.Clear()
        data.Columns(6).DefaultCellStyle.Format = "yyyy/MM/dd"
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM purchase", conn)
            reader = cmd.ExecuteReader

            While reader.Read

                data.Rows.Add(reader.Item("purchase_no"), reader.Item("student_id"), reader.Item("product_id"), reader.Item("prod_name"), reader.Item("size"), reader.Item("quantity"), reader.Item("date_purchase"), reader.Item("total"))
            End While

            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clear_data()
        stuid.Clear()
        Total.Clear()
        pidbox.SelectedIndex = -1
        pname.Clear()
        prodsize.Text = ""
        prodquant.Text = ""
        price.Text = ""
        datepur.Value = DateTime.Now
        purchasenum.Clear()
        add_btn.Enabled = True
    End Sub

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        purchasenum.Text = data.CurrentRow.Cells(0).Value
        stuid.Text = data.CurrentRow.Cells(1).Value
        pidbox.Text = data.CurrentRow.Cells(2).Value
        pname.Text = data.CurrentRow.Cells(3).Value
        prodsize.Text = data.CurrentRow.Cells(4).Value
        prodquant.Text = data.CurrentRow.Cells(5).Value
        datepur.Text = data.CurrentRow.Cells(6).Value
        Total.Text = data.CurrentRow.Cells(7).Value

        add_btn.Enabled = False
       
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `purchase` SET `product_id`= @product_id,`prod_name`=@prod_name,`size`=@size,`quantity`=@quantity,`prod_price`=@prod_price, `date_purchase`=@date_purchase, `total`=@total  WHERE `purchase_no`=@purchase_no", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@purchase_no", purchasenum.Text)
            cmd.Parameters.AddWithValue("@student_id", stuid.Text)
            cmd.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmd.Parameters.AddWithValue("@prod_name", pname.Text)
            cmd.Parameters.AddWithValue("@size", prodsize.Text)
            cmd.Parameters.AddWithValue("@quantity", prodquant.Text)
            cmd.Parameters.AddWithValue("@prod_price", CDec(price.Text))
            cmd.Parameters.AddWithValue("@date_purchase", CDate(datepur.Text))
            cmd.Parameters.AddWithValue("@total", CDec(Total.Text))
            i = cmd.ExecuteNonQuery
     
                If i > 0 Then
                    MessageBox.Show("Record Updated", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record not updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        clear_data()
        data_load()
        data_load2()

    End Sub

    Private Sub updt_btn_Click(sender As Object, e As EventArgs) Handles updt_btn.Click
        edit()
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        data.Rows.Clear()
        data.Columns(6).DefaultCellStyle.Format = "yyyy/MM/dd"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM purchase WHERE student_id like '%" & search_box.Text & "%' OR product_id like '%" & search_box.Text & "%' ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("purchase_no"), reader.Item("student_id"), reader.Item("product_id"), reader.Item("prod_name"), reader.Item("size"), reader.Item("quantity"), reader.Item("date_purchase"), reader.Item("total"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub remove()
        If MsgBox("Are you sure that you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `purchase` WHERE `purchase_no`=@purchase_no", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@purchase_no", purchasenum.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record not deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear_data()
            data_load()
            data_load2()

        Else
            Return
        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        remove()
    End Sub

    Public Sub data_load2()
        data2.Rows.Clear()
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product WHERE product_stocks > 0", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data2.Rows.Add(reader.Item("product_id"), reader.Item("product_type"), reader.Item("product_size"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
