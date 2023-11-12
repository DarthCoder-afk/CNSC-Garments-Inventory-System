Imports MySql.Data.MySqlClient

Public Class Supplies1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private _prodID As String

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(prodID As String)
        InitializeComponent()
        _prodID = prodID
    End Sub

    Private Sub stuid_TextChanged(sender As Object, e As EventArgs) Handles supid.TextChanged
        Dim supplierID As String = supid.Text.Trim()
        Dim sqlQuery As String = "SELECT supplier_name, supplier_contact_num FROM supplier WHERE supplier_id = @supplier_id"

        supid.MaxLength = 7

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@supplier_id", supplierID)

        conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            name.Text = reader.GetString("supplier_name")
            contactnum.Text = reader.GetString("supplier_contact_num")

        Else

            name.Clear()
            contactnum.Clear()

        End If


        reader.Close()
        conn.Close()
    End Sub

    Private Sub pidbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pidbox.SelectedIndexChanged
        Dim productID As String = pidbox.Text.Trim()
        Dim sqlQuery As String = "SELECT product_type, product_size, current_unit_price, product_stocks FROM product WHERE product_id = @productID"

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@productID", productID)

        conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            pname.Text = reader.GetString("product_type")
            prodsize.Text = reader.GetString("product_size")

            Dim currentStocks As Integer = reader.GetInt32("product_stocks")
            Dim remainingStocks As Integer = 100 - currentStocks

            If remainingStocks <= 0 Then
                prodquant.Text = "0"
            Else
                prodquant.Text = remainingStocks.ToString()
            End If
        Else
            pname.Clear()
            prodsize.Clear()
            prodquant.Clear()
        End If

        reader.Close()
        conn.Close()
    End Sub

    Private Sub Supplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        pidbox.SelectedIndex = pidbox.FindStringExact(_prodID)
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If supid.Text = "" Or pidbox.Text = "" Or prodsize.Text = "" Or prodquant.Text = "" Then
            MsgBox("Please fill in all required fields.")
            Return
        End If
        Dim TransacNo As Integer = 0
        Dim strGetMaxID As String = "SELECT MAX(transac_no) FROM supplies"
        Dim strInsert As String = "INSERT INTO supplies (transac_no, supplier_id, product_id, product_type, quantity, arrival_date) " &
            "VALUES (@transac_no, @supplier_id, @product_id, @product_type, @quantity, @arrival_date)"

        Try
            conn.Open()

            ' Get the maximum purchase number and increment by 1
            Dim cmdGetMaxID As New MySqlCommand(strGetMaxID, conn)
            Dim maxID = cmdGetMaxID.ExecuteScalar()
            If Not IsDBNull(maxID) Then
                TransacNo = CType(maxID, Integer) + 1
            Else
                TransacNo = 1
            End If

            ' Concatenate prod_name and prod_size as product_type
            Dim productType As String = pname.Text & " - " & prodsize.Text


            Dim cmdInsert As New MySqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@transac_no", TransacNo)
            cmdInsert.Parameters.AddWithValue("@supplier_id", supid.Text)
            cmdInsert.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmdInsert.Parameters.AddWithValue("@product_type", productType)
            cmdInsert.Parameters.AddWithValue("@quantity", prodquant.Text)
            cmdInsert.Parameters.AddWithValue("@arrival_date", arrivaldate.Value.ToString("yyyy-MM-dd"))

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
    Public Sub data_load()
        data.Rows.Clear()
        data.Columns(5).DefaultCellStyle.Format = "yyyy/MM/dd"
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM supplies", conn)
            reader = cmd.ExecuteReader

            While reader.Read

                data.Rows.Add(reader.Item("transac_no"), reader.Item("supplier_id"), reader.Item("product_id"), reader.Item("product_type"), reader.Item("quantity"), reader.Item("arrival_date"))
            End While

            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clear_data()
        supid.Clear()
        pidbox.SelectedIndex = -1
        prodquant.Text = ""
        arrivaldate.Value = DateTime.Now
        add_btn.Enabled = True
        supid.Enabled = True
        transactno.Text = ""
    End Sub

    Public Sub data_load2()
        data2.Rows.Clear()
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM product", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data2.Rows.Add(reader.Item("product_id"), reader.Item("product_type"), reader.Item("product_size"), reader.Item("product_stocks"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub


    Sub edit()
        Try
            conn.Open()
            Dim productType As String = pname.Text & " - " & prodsize.Text
            Dim cmd As New MySqlCommand("UPDATE `supplies` SET `product_id`= @product_id, `product_type`=@product_type, `quantity`=@quantity, `supplier_id`=@supplier_id, `arrival_date`=@arrival_date WHERE `transac_no`=@transac_no", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@supplier_id", supid.Text)
            cmd.Parameters.AddWithValue("@product_id", pidbox.Text)
            cmd.Parameters.AddWithValue("@product_type", productType)
            cmd.Parameters.AddWithValue("@quantity", prodquant.Text)
            cmd.Parameters.AddWithValue("@arrival_date", arrivaldate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@transac_no", transactno.Text)
            i = cmd.ExecuteNonQuery()

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

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        transactno.Text = data.CurrentRow.Cells(0).Value
        supid.Text = data.CurrentRow.Cells(1).Value
        pidbox.Text = data.CurrentRow.Cells(2).Value
        prodquant.Text = data.CurrentRow.Cells(4).Value
        arrivaldate.Text = data.CurrentRow.Cells(5).Value


        add_btn.Enabled = False
        supid.Enabled = False
    End Sub

    Public Sub remove()
        If MsgBox("Are you sure that you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `supplies` WHERE `transac_no`=@transac_no", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@transac_no", transactno.Text)

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
End Class