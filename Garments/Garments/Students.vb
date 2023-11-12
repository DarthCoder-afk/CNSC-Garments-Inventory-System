Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class Students

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim reader As MySqlDataReader
    Dim i As Integer

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dept.DropDownStyle = ComboBoxStyle.DropDownList
        blck.DropDownStyle = ComboBoxStyle.DropDownList
        yrlvl.DropDownStyle = ComboBoxStyle.DropDownList

        data_load()


        Dim str As String
        str = "Select distinct department from student"
        Try
            readqueary(str)
            With cmdread
                While .Read
                    dept.Items.Add(.GetValue(0))
                End While
            End With
        Catch ex As Exception

        End Try

    End Sub



    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim prefix As String = "21-"
        Dim str As String
        Dim lastId As String = Nothing
        Dim numericPart As Integer
        Dim newNumericPart As String
        Dim newId As String
       
        ' Get the last ID from the database
        str = "SELECT MAX(student_id) FROM student"
        Try
            conn.Open()
            Dim insertCommand As New MySqlCommand(str, conn)
            Dim result = insertCommand.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                lastId = result.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

        ' Increment the ID
        If lastId IsNot Nothing AndAlso lastId.StartsWith(prefix) Then
            numericPart = CInt(lastId.Substring(3))
            newNumericPart = (numericPart + 1).ToString("0000")
        Else
            newNumericPart = "0001"
        End If
        newId = prefix & newNumericPart

        ' Insert the new record into the database
        str = "INSERT INTO student(student_id, student_fname, student_lname, block, course, department, year_level) " &
            "VALUES ('" & newId & "', '" & fname.Text & "','" & lname.Text & "', '" & blck.Text & "', '" & course.Text & "', '" & dept.Text & "', '" & yrlvl.Text & "')"

        Try
            conn.Open()
            Dim insertCommand As New MySqlCommand(str, conn)
            insertCommand.ExecuteNonQuery()
            MsgBox("New Record Added")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        clear_data()
        data_load()
    End Sub




    Private Sub dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dept.SelectedIndexChanged


        Dim str, str1 As String
        str = "Select distinct department, course from student where department = '" & dept.Text & "' "
        Try
            readqueary(str)
            With cmdread
                While .Read
                    course.Items.Add(.GetValue(1))
                End While
            End With
        Catch ex As Exception

        End Try




    End Sub

    Public Sub data_load()
        data.Rows.Clear()
        course.DropDownStyle = ComboBoxStyle.DropDownList
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM student", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("student_id"), reader.Item("student_fname"), reader.Item("student_lname"), reader.Item("block"), reader.Item("course"), reader.Item("department"), reader.Item("year_level"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try



    End Sub






    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        id.Text = data.CurrentRow.Cells(0).Value
        fname.Text = data.CurrentRow.Cells(1).Value
        lname.Text = data.CurrentRow.Cells(2).Value
        blck.Text = data.CurrentRow.Cells(3).Value
        course.Text = data.CurrentRow.Cells(4).Value
        dept.Text = data.CurrentRow.Cells(5).Value
        yrlvl.Text = data.CurrentRow.Cells(6).Value

        id.ReadOnly = True
        add_btn.Enabled = False

    End Sub


    Public Sub clear_data()
        id.Clear()
        fname.Clear()
        lname.Clear()
        blck.SelectedIndex = -1
        course.SelectedIndex = -1
        dept.SelectedIndex = -1
        yrlvl.SelectedIndex = -1

        add_btn.Enabled = True
        id.ReadOnly = False


    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `student` SET `student_fname`= @student_fname,`student_lname`=@student_lname,`block`=@block,`course`=@course,`department`=@department,`year_level`=@year_level WHERE `student_id`=@student_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@student_id", id.Text)
            cmd.Parameters.AddWithValue("@student_fname", fname.Text)
            cmd.Parameters.AddWithValue("@student_lname", lname.Text)
            cmd.Parameters.AddWithValue("@block", blck.Text)
            cmd.Parameters.AddWithValue("@course", course.Text)
            cmd.Parameters.AddWithValue("@department", dept.Text)
            cmd.Parameters.AddWithValue("@year_level", yrlvl.Text)

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
                Dim cmd As New MySqlCommand("DELETE FROM `student` WHERE `student_id`=@student_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@student_id", id.Text)

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
            Dim cmd As New MySqlCommand("SELECT * FROM student WHERE student_id like '%" & search_box.Text & "%' OR student_fname like '%" & search_box.Text & "%' ", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                data.Rows.Add(reader.Item("student_id"), reader.Item("student_fname"), reader.Item("student_lname"), reader.Item("block"), reader.Item("course"), reader.Item("department"), reader.Item("year_level"))
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



    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        id.MaxLength = 7
    End Sub

   
   
End Class
