Imports MySql.Data.MySqlClient
Public Class Staff

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim reader As MySqlDataReader
    Dim i As Integer


    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
    End Sub

    Public Sub data_load()
        data.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM staff", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("staff_id"), reader.Item("staff_fname"), reader.Item("staff_lname"), reader.Item("position"))
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

        str = "INSERT INTO staff(staff_id, staff_fname, staff_lname, position) " &
            "VALUES ('" & staid.Text & "', '" & fname.Text & "','" & lname.Text & "','" & pos.Text & "')"

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
        staid.Clear()
        fname.Clear()
        lname.Clear()
        pos.Clear()


        add_btn.Enabled = True
        staid.ReadOnly = False


    End Sub


    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        staid.Text = data.CurrentRow.Cells(0).Value
        fname.Text = data.CurrentRow.Cells(1).Value
        lname.Text = data.CurrentRow.Cells(2).Value
        pos.Text = data.CurrentRow.Cells(3).Value


        staid.ReadOnly = True
        add_btn.Enabled = False
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `staff` SET `staff_fname`= @staff_fname,`staff_lname`=@staff_lname, `position`=@position WHERE `staff_id`=@staff_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@staff_id", staid.Text)
            cmd.Parameters.AddWithValue("@staff_fname", fname.Text)
            cmd.Parameters.AddWithValue("@staff_lname", lname.Text)
            cmd.Parameters.AddWithValue("@position", pos.Text)


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
                Dim cmd As New MySqlCommand("DELETE FROM `staff` WHERE `staff_id`=@staff_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@staff_id", staid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record not deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception

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
            Dim cmd As New MySqlCommand("SELECT * FROM staff WHERE staff_id like '%" & search_box.Text & "%' OR staff_fname like '%" & search_box.Text & "%' ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("staff_id"), reader.Item("staff_fname"), reader.Item("staff_lname"), reader.Item("position"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub updt_btn_Click_1(sender As Object, e As EventArgs)
        edit()

    End Sub
End Class