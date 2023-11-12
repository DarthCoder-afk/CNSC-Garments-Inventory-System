
Imports MySql.Data.MySqlClient
Public Class Cashier

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
    End Sub


    Public Sub data_load()
        data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM cashier", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("cashier_id"), reader.Item("cashier_fname"), reader.Item("cashier_lname"))
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

        str = "INSERT INTO cashier(cashier_id, cashier_fname, cashier_lname) " &
            "VALUES ('" & cid.Text & "', '" & fname.Text & "','" & lname.Text & "')"

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
        cid.Clear()
        fname.Clear()
        lname.Clear()
        

        add_btn.Enabled = True
        cid.ReadOnly = False


    End Sub

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        cid.Text = data.CurrentRow.Cells(0).Value
        fname.Text = data.CurrentRow.Cells(1).Value
        lname.Text = data.CurrentRow.Cells(2).Value
       

        cid.ReadOnly = True
        add_btn.Enabled = False
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `cashier` SET `cashier_fname`= @cashier_fname,`cashier_lname`=@cashier_lname", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@cashier_id", cid.Text)
            cmd.Parameters.AddWithValue("@cashier_fname", fname.Text)
            cmd.Parameters.AddWithValue("@cashier_lname", lname.Text)
           

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

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        remove()
    End Sub


    Public Sub remove()
        If MsgBox("Are you sure that you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `cashier` WHERE `cashier_id`=@cashier_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@cashier_id", cid.Text)

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

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM cashier WHERE cashier_id like '%" & search_box.Text & "%' OR cashier_fname like '%" & search_box.Text & "%' ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("cashier_id"), reader.Item("cashier_fname"), reader.Item("cashier_lname"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class