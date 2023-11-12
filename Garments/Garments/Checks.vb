Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class Checks
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim i As Integer

    Private Sub staffid_TextChanged(sender As Object, e As EventArgs) Handles staid.TextChanged
        Dim staffID As String = staid.Text.Trim()
        Dim sqlQuery As String = "SELECT staff_fname, staff_lname, position FROM staff WHERE staff_id = @staff_id"

        staid.MaxLength = 5

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@staff_id", staffID)

        conn.Open()

         Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            fname.Text = reader.GetString("staff_fname")
            lname.Text = reader.GetString("staff_lname")
            position.Text = reader.GetString("position")

        Else

            fname.Clear()
            lname.Clear()
            position.Clear()

        End If


        reader.Close()
        conn.Close()
    End Sub

   

   
    

    Public Sub data_load2()
        data2.Rows.Clear()
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data2.Rows.Add(reader.Item("product_id"), reader.Item("product_type"), reader.Item("product_size"), reader.Item("product_stocks"), reader.Item("current_unit_price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Checks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()

        data_load2()

        data_load3()

        stocks.DropDownStyle = ComboBoxStyle.DropDownList

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

    Private Sub save_btn_Clicked(sender As Object, e As EventArgs) Handles save_btn.Click

        Dim quantity As Integer
        If Not Integer.TryParse(prodquant.Text, quantity) Then
            MsgBox("Invalid product quantity. Please enter a positive integer value.")
            Return
        End If


        If staid.Text = "" Or pidbox.Text = "" Or prodsize.Text = "" Or prodquant.Text = "" Or price.Text = "" Or stocks.Text = "" Then
            MsgBox("Please fill in all required fields.")
            Return
        End If
        Dim evalNo As Integer = 0
        Dim strGetMaxID As String = "SELECT MAX(No) FROM checks"
        Dim strInsert As String = "INSERT INTO checks (No, staff_id, product_id, eval_date, status) " &
            "VALUES (@No, @staff_id, @product_id, @eval_date, @status)"

        conn.Open()


        Dim strGetPosition As String = "SELECT position FROM staff WHERE staff_id = @staff_id"
        Dim cmdGetPosition As New MySqlCommand(strGetPosition, conn)
        cmdGetPosition.Parameters.AddWithValue("@staff_id", staid.Text)
        Dim position As String = CStr(cmdGetPosition.ExecuteScalar())

        conn.Close()

        If position <> "Head" Then
            MsgBox("Only users with position 'Head' can save data.")
            Return
        End If

        Try
            conn.Open()

            ' Get the maximum purchase number and increment by 1
            Dim cmdGetMaxID As New MySqlCommand(strGetMaxID, conn)
            Dim maxID = cmdGetMaxID.ExecuteScalar()
            If Not IsDBNull(maxID) Then
                evalNo = CType(maxID, Integer) + 1
            Else
                evalNo = 1
            End If

            ' Calculate total and insert the new record with the incremented purchase number and total
            Dim totalPrice As Double = CDbl(price.Text) * CDbl(prodquant.Text)
            Dim cmdInsert As New MySqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@No", evalNo)
            cmdInsert.Parameters.AddWithValue("@staff_id", staid.Text)
            cmdInsert.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmdInsert.Parameters.AddWithValue("@eval_date", evaldate.Value.ToString("yyyy-MM-dd"))
            cmdInsert.Parameters.AddWithValue("@status", stocks.Text)

            cmdInsert.ExecuteNonQuery()


            ' Update the product table with the new stock
            Dim cmd As New MySqlCommand("UPDATE `product` SET `product_type`= @product_type,`product_size`=@product_size,`product_stocks`=@product_stocks,`current_unit_price`=@current_unit_price  WHERE `product_id`=@product_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmd.Parameters.AddWithValue("@product_type", pname.Text)
            cmd.Parameters.AddWithValue("@product_size", prodsize.Text)
            cmd.Parameters.AddWithValue("@product_stocks", prodquant.Text)
            cmd.Parameters.AddWithValue("@current_unit_price", price.Text)

            cmd.ExecuteNonQuery()

            MsgBox("New Record Saved")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

        clear_data()
        data_load()
        data_load2()
        data_load3()

    End Sub


    Public Sub data_load()
        data.Rows.Clear()
        data.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd"
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM checks", conn)
            reader = cmd.ExecuteReader

            While reader.Read

                data.Rows.Add(reader.Item("No"), reader.Item("staff_id"), reader.Item("product_id"), reader.Item("eval_date"), reader.Item("status"))
            End While

            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clear_data()
        staid.Clear()
        pidbox.SelectedIndex = -1
        pname.Clear()
        prodsize.Text = ""
        prodquant.Text = ""
        price.Text = ""
        evaldate.Value = DateTime.Now
        evalnum.Clear()
      
        stocks.SelectedIndex = -1
    End Sub



    Private Sub updt_btn_Click(sender As Object, e As EventArgs) Handles updt_btn.Click
        edit()


    End Sub

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        evalnum.Text = data.CurrentRow.Cells(0).Value
        staid.Text = data.CurrentRow.Cells(1).Value
        pidbox.Text = data.CurrentRow.Cells(2).Value
        evaldate.Text = data.CurrentRow.Cells(3).Value
        stocks.Text = data.CurrentRow.Cells(4).Value
       


        save_btn.Enabled = False
        staid.Enabled = False
    End Sub


  Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `product` SET `product_type`= @product_type, `product_size`=@product_size, `product_stocks`=@product_stocks, `current_unit_price`=@current_unit_price WHERE `product_id`=@product_id", conn)
            cmd.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmd.Parameters.AddWithValue("@product_type", pname.Text)
            cmd.Parameters.AddWithValue("@product_size", prodsize.Text)
            cmd.Parameters.AddWithValue("@product_stocks", prodquant.Text)
            cmd.Parameters.AddWithValue("@current_unit_price", price.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()

            Dim checkscmd As New MySqlCommand("UPDATE `checks` SET `staff_id`= @staff_id, `product_id`=@product_id, `eval_date`=@eval_date WHERE `No`=@No", conn)
            checkscmd.Parameters.AddWithValue("@No", evalnum.Text)
            checkscmd.Parameters.AddWithValue("@staff_id", staid.Text)
            checkscmd.Parameters.AddWithValue("@product_id", pidbox.Text)
            checkscmd.Parameters.AddWithValue("@eval_date", CDate(evaldate.Text))
            checkscmd.Parameters.AddWithValue("@status", stocks.Text)

            Dim j As Integer = checkscmd.ExecuteNonQuery()

            If i > 0 And j > 0 Then
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
        data_load3()

    End Sub

    Private Sub pidbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pidbox.SelectedIndexChanged
        Dim prodID As String = pidbox.Text.Trim()
        Dim sqlQuery As String = "SELECT p.product_type, p.product_size, p.product_stocks, p.current_unit_price," &
                          " SUM(pr.quantity) as sold_items, " &
                          " SUM(pr.quantity * pr.prod_price) as total_income " &
                          "FROM product p " &
                          "LEFT JOIN purchase pr ON p.product_id = pr.product_id " &
                          "WHERE p.product_id = @product_id " &
                          "GROUP BY p.product_type, p.product_size, p.product_stocks, p.current_unit_price"


        pidbox.MaxLength = 2

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@product_id", prodID)

        conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()



        If reader.Read() Then
            pname.Text = reader.GetString("product_type")
            prodsize.Text = reader.GetString("product_size")
            prodquant.Text = reader.GetString("product_stocks")
            price.Text = reader.GetString("current_unit_price")
            If reader.IsDBNull(reader.GetOrdinal("sold_items")) Then
                sold.Text = "0"
            Else
                sold.Text = reader.GetInt32("sold_items").ToString()
            End If

            If reader.IsDBNull(reader.GetOrdinal("total_income")) Then
                income.Text = "0.00"
            Else
                income.Text = reader.GetDecimal("total_income").ToString()
            End If

            Dim stockQuantity As Integer = Integer.Parse(prodquant.Text)
            If stockQuantity < 50 Then
                MessageBox.Show("The stock of this product is below 50.")
               

            End If

            If stockQuantity = 0 Then
                MessageBox.Show("The stock of this product is zero. Need to Restock.")
                ' Remove the unavailable product from the product combobox
               Dim selectedProductID As String = pidbox.SelectedItem.ToString()
                Dim suppliesForm As New Supplies1(selectedProductID)
                suppliesForm.Show()
            End If

        Else
            clear_data()

        End If

        reader.Close()
        conn.Close()


    End Sub

    Public Sub data_load3()
        data3.Rows.Clear()
        data3.Columns(6).DefaultCellStyle.Format = "yyyy/MM/dd"
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM purchase", conn)
            reader = cmd.ExecuteReader

            While reader.Read

                data3.Rows.Add(reader.Item("purchase_no"), reader.Item("student_id"), reader.Item("product_id"), reader.Item("prod_name"), reader.Item("size"), reader.Item("quantity"), reader.Item("date_purchase"), reader.Item("total"))
            End While

            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    
    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        data.Rows.Clear()
        data2.Rows.Clear()
        data.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd"

        data3.Rows.Clear()
        data3.Columns(6).DefaultCellStyle.Format = "yyyy/MM/dd"

        If String.IsNullOrEmpty(search_box.Text) Then
            data_load()
            data_load2()
            data_load3()

        Else
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM checks c INNER JOIN product p ON c.product_id = p.product_id INNER JOIN purchase pr ON pr.product_id = p.product_id WHERE p.product_id LIKE @searchText", conn)
                cmd.Parameters.AddWithValue("@searchText", "%" & search_box.Text & "%")

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    data.Rows.Add(reader.Item("No"), reader.Item("staff_id"), reader.Item("product_id"), reader.Item("eval_date"))
                    data2.Rows.Add(reader.Item("product_id"), reader.Item("product_type"), reader.Item("product_size"), reader.Item("product_stocks"), reader.Item("current_unit_price"))
                    data3.Rows.Add(reader.Item("purchase_no"), reader.Item("student_id"), reader.Item("product_id"), reader.Item("prod_name"), reader.Item("size"), reader.Item("quantity"), reader.Item("date_purchase"), reader.Item("total"))
                End While

                reader.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub


    Private Sub data2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data2.CellContentClick
        pidbox.Text = data2.CurrentRow.Cells(0).Value
        pname.Text = data2.CurrentRow.Cells(1).Value
        prodsize.Text = data2.CurrentRow.Cells(2).Value
        prodquant.Text = data2.CurrentRow.Cells(3).Value
        price.Text = data2.CurrentRow.Cells(4).Value

       

    End Sub

   

   

End Class