Imports MySql.Data.MySqlClient
Public Class Supplier

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
    End Sub

    Public Sub data_load()
        data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM supplier", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("supplier_id"), reader.Item("supplier_name"), reader.Item("supplier_contact_num"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try



    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim str As String

        str = "INSERT INTO supplier(supplier_id, supplier_name, supplier_contact_num) " &
            "VALUES ('" & sid.Text & "', '" & supp_name.Text & "','" & contact.Text & "')"

        Try
            readqueary(str)
            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)

        Finally
            conn.Close()
        End Try
        clear_data()
        data_load()
    End Sub

    Public Sub clear_data()
        sid.Clear()
        supp_name.Clear()
        contact.Clear()


        add_btn.Enabled = True
        sid.ReadOnly = False


    End Sub


    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        sid.Text = data.CurrentRow.Cells(0).Value
        supp_name.Text = data.CurrentRow.Cells(1).Value
        contact.Text = data.CurrentRow.Cells(2).Value


        sid.ReadOnly = True
        add_btn.Enabled = False
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub


    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `supplier` SET `supplier_name`= @supplier_name,`supplier_contact_num`=@supplier_contact_num", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@supplier_id", sid.Text)
            cmd.Parameters.AddWithValue("@supplier_name", supp_name.Text)
            cmd.Parameters.AddWithValue("@supplier_contact_num", contact.Text)


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
                Dim cmd As New MySqlCommand("DELETE FROM `supplier` WHERE `supplier_id`=@supplier_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@supplier_id", sid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record not deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception

            End Try

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
            Dim cmd As New MySqlCommand("SELECT * FROM supplier WHERE supplier_id like '%" & search_box.Text & "%' OR supplier_name like '%" & search_box.Text & "%' ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("supplier_id"), reader.Item("supplier_name"), reader.Item("supplier_contact_num"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class