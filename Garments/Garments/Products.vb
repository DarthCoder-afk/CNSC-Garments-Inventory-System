Imports MySql.Data.MySqlClient
Public Class Products

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim reader As MySqlDataReader
    Dim i As Integer


    Public Sub data_load()
        data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("product_id"), reader.Item("product_type"), reader.Item("product_size"), reader.Item("product_stocks"), reader.Item("current_unit_price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try



    End Sub


    Public Sub clear_data()
        pid.Clear()
        pname.Clear()
        psize.Clear()
        pstocks.Clear()
        pprice.Clear()
       

        add_btn.Enabled = True



    End Sub



    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim productID As Integer = 0
        Dim strGetMaxID As String = "SELECT MAX(product_id) FROM product"
        Dim strInsert As String = "INSERT INTO product   (product_id, product_type, product_size, product_stocks, current_unit_price) " &
            "VALUES (@product_id, @product_type, @product_size, @product_stocks, @current_unit_price)"

        Try
            conn.Open()

            ' Get the maximum purchase number and increment by 1
            Dim cmdGetMaxID As New MySqlCommand(strGetMaxID, conn)
            Dim maxID = cmdGetMaxID.ExecuteScalar()
            If Not IsDBNull(maxID) Then
                productID = CType(maxID, Integer) + 1
            Else
                productID = 1
            End If

            ' Calculate total and insert the new record with the incremented purchase number and total
            Dim cmdInsert As New MySqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@product_id", productID)
            cmdInsert.Parameters.AddWithValue("@product_type", pname.Text)
            cmdInsert.Parameters.AddWithValue("@product_size", psize.Text)
            cmdInsert.Parameters.AddWithValue("@product_stocks", pstocks.Text)
            cmdInsert.Parameters.AddWithValue("@current_unit_price", pprice.Text)
            cmdInsert.ExecuteNonQuery()

            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

        clear_data()
        data_load()
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick

        pid.Text = data.CurrentRow.Cells(0).Value
        pname.Text = data.CurrentRow.Cells(1).Value
        psize.Text = data.CurrentRow.Cells(2).Value
        pstocks.Text = data.CurrentRow.Cells(3).Value
        pprice.Text = data.CurrentRow.Cells(4).Value



        add_btn.Enabled = False
        Dim stockQuantity As Integer = Integer.Parse(pstocks.Text)
        If stockQuantity < 50 Then
            MessageBox.Show("The stock of this product is below 50.")
        End If
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `product` SET `product_type`= @product_type,`product_size`=@product_size,`product_stocks`=@product_stocks,`current_unit_price`=@current_unit_price  WHERE `product_id`=@product_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", pid.Text)
            cmd.Parameters.AddWithValue("@product_type", pname.Text)
            cmd.Parameters.AddWithValue("@product_size", psize.Text)
            cmd.Parameters.AddWithValue("@product_stocks", pstocks.Text)
            cmd.Parameters.AddWithValue("@current_unit_price", pprice.Text)
      
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

    End Sub

    Private Sub updt_btn_Click(sender As Object, e As EventArgs) Handles updt_btn.Click
        edit()

    End Sub


    Public Sub remove()
        If MsgBox("Are you sure that you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `product` WHERE `product_id`=@product_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@product_id", pid.Text)

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

        Else
            Return
        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        remove()

    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product WHERE product_id like '%" & search_box.Text & "%' OR product_type like '%" & search_box.Text & "%' ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("product_id"), reader.Item("product_type"), reader.Item("product_size"), reader.Item("product_stocks"), reader.Item("current_unit_price"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class