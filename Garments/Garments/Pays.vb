Imports MySql.Data.MySqlClient
Imports System.Data.OleDb


Public Class Pays
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=cnsc garments")
    Dim i As Integer

   
    Private studentID As String
    Private purchaseNumber As String

    Public Sub New(ByVal studentID As String, ByVal purchaseNumber As String)
        InitializeComponent()
        Me.studentID = studentID
        Me.purchaseNumber = purchaseNumber
    End Sub

    Sub New()
        InitializeComponent()
        Me.studentID = studentID
        Me.purchaseNumber = purchaseNumber
    End Sub

  

    Private Sub Pays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stuid.Text = studentID
        purchasenum.Text = purchaseNumber

        data_load()
    End Sub

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

            ' Populate purchase numbers related to the selected student ID
            purchasenum.Items.Clear()
            sqlQuery = "SELECT DISTINCT purchase_no FROM purchase WHERE student_id = @studentID"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@studentID", studentID)
            reader.Close()
            reader = cmd.ExecuteReader()
            While reader.Read()
                purchasenum.Items.Add(reader.GetString("purchase_no"))
            End While
        Else
            fname.Clear()
            lname.Clear()
            coursestud.Clear()
            dept.Clear()
            purchasenum.Items.Clear()
        End If

        reader.Close()
        conn.Close()
    End Sub

    Private Sub purchasenum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles purchasenum.SelectedIndexChanged
        If purchasenum.SelectedIndex > -1 Then
            Dim studentID As String = stuid.Text.Trim()
            Dim purchaseNumber As String = purchasenum.SelectedItem.ToString()
            Dim sqlQuery As String = "SELECT total FROM purchase WHERE purchase_no = @purchase_no AND student_id = @studentID"

            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@purchase_no", purchaseNumber)
            cmd.Parameters.AddWithValue("@studentID", studentID)

            conn.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Total.Text = reader.GetString("total")
            End If

            reader.Close()
            conn.Close()
        End If
    End Sub

    Private Sub cashid_TextChanged(sender As Object, e As EventArgs) Handles cashid.TextChanged
        Dim cashierid As String = cashid.Text.Trim()
        Dim sqlQuery As String = "SELECT cashier_fname, cashier_lname FROM cashier WHERE cashier_id = @cashID"

        cashid.MaxLength = 6

        Dim cmd As New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@cashID", cashierid)

        conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            cashfname.Text = reader.GetString("cashier_fname")
            cashlname.Text = reader.GetString("cashier_lname")
        Else

            cashfname.Clear()
            cashlname.Clear()
        End If


        reader.Close()
        conn.Close()

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim ordernum As Integer = 0
        Dim strGetMaxID As String = "SELECT MAX(ornum) FROM pays"
        Dim strInsert As String = "INSERT INTO pays (ornum, student_id, cashier_id, transact_date, payment, status) " &
            "VALUES (@ornum, @student_id, @cashier_id, @transact_date, @payment, @status)"

        Try
            conn.Open()

            ' Get the maximum purchase number and increment by 1
            Dim cmdGetMaxID As New MySqlCommand(strGetMaxID, conn)
            Dim maxID = cmdGetMaxID.ExecuteScalar()
            If Not IsDBNull(maxID) Then
                ordernum = CType(maxID, Integer) + 1
            Else
                ordernum = 1
            End If

            ' Calculate total and insert the new record with the incremented purchase number and total
            Dim cmdInsert As New MySqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@ornum", ordernum)
            cmdInsert.Parameters.AddWithValue("@student_id", stuid.Text)
            cmdInsert.Parameters.AddWithValue("@cashier_id", cashid.Text)
            cmdInsert.Parameters.AddWithValue("@transact_date", datetrans.Value.ToString("yyyy-MM-dd"))
            cmdInsert.Parameters.AddWithValue("@payment", CDec(Total.Text))
            cmdInsert.Parameters.AddWithValue("@status", "PAID")
           
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
        data.Columns(3).DefaultCellStyle.Format = "yyyy/MM/dd"
        purchasenum.DropDownStyle = ComboBoxStyle.DropDownList
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM pays", conn)
            reader = cmd.ExecuteReader

            While reader.Read
                data.Rows.Add(reader.Item("ornum"), reader.Item("student_id"), reader.Item("cashier_id"), reader.Item("transact_date"), reader.Item("payment"), reader.Item("status"))
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
        cashid.Clear()
        Total.Clear()
        purchasenum.SelectedIndex = -1
        datetrans.Value = DateTime.Now
        fname.Clear()
        lname.Clear()
        coursestud.Clear()
        dept.Clear()
        cashfname.Clear()
        cashlname.Clear()
        Orderno.Clear()
        status.Clear()

        add_btn.Enabled = True
    End Sub


    

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        clear_data()
    End Sub


    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `pays` SET `student_id`= @student_id,`cashier_id`=@cashier_id, `transact_date`=@transact_date, `payment`=@payment WHERE `ornum`=@ornum", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ornum", Orderno.Text)
            cmd.Parameters.AddWithValue("@student_id", stuid.Text)
            cmd.Parameters.AddWithValue("@cashier_id", cashid.Text)
            cmd.Parameters.AddWithValue("@transact_date", CDate(datetrans.Text))
            cmd.Parameters.AddWithValue("@payment", CDec(Total.Text))

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

    Private Sub data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick
        Orderno.Text = data.CurrentRow.Cells(0).Value
        stuid.Text = data.CurrentRow.Cells(1).Value
        cashid.Text = data.CurrentRow.Cells(2).Value
        datetrans.Text = data.CurrentRow.Cells(3).Value
        Total.Text = data.CurrentRow.Cells(4).Value
        status.Text = data.CurrentRow.Cells(5).Value

        add_btn.Enabled = False
        purchasenum.Enabled = False
        purchasenum.BackColor = Color.LightGray

       
    End Sub

    Public Sub remove()
        If MsgBox("Are you sure that you want to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `pays` WHERE `ornum`=@ornum", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ornum", Orderno.Text)

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
