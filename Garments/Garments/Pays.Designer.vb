<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pays
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dept = New System.Windows.Forms.TextBox()
        Me.coursestud = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datetrans = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.updt_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stuid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cashfname = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cashlname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.purchasenum = New System.Windows.Forms.ComboBox()
        Me.cashid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Orderno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 26)
        Me.Label14.TabIndex = 167
        Me.Label14.Text = "Cashier"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 18)
        Me.Label13.TabIndex = 166
        Me.Label13.Text = "Department"
        '
        'dept
        '
        Me.dept.Location = New System.Drawing.Point(332, 142)
        Me.dept.Name = "dept"
        Me.dept.ReadOnly = True
        Me.dept.Size = New System.Drawing.Size(88, 20)
        Me.dept.TabIndex = 165
        '
        'coursestud
        '
        Me.coursestud.Location = New System.Drawing.Point(123, 142)
        Me.coursestud.Name = "coursestud"
        Me.coursestud.ReadOnly = True
        Me.coursestud.Size = New System.Drawing.Size(88, 20)
        Me.coursestud.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Course"
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(538, 95)
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        Me.lname.Size = New System.Drawing.Size(88, 20)
        Me.lname.TabIndex = 162
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(436, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "Last Name"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(332, 96)
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        Me.fname.Size = New System.Drawing.Size(88, 20)
        Me.fname.TabIndex = 160
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 26)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Student Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(229, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 18)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "First Name"
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(569, 142)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(57, 20)
        Me.Total.TabIndex = 155
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 18)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Total Purchase"
        '
        'datetrans
        '
        Me.datetrans.CustomFormat = "yyyy-MM-dd"
        Me.datetrans.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetrans.Location = New System.Drawing.Point(163, 385)
        Me.datetrans.Name = "datetrans"
        Me.datetrans.Size = New System.Drawing.Size(149, 20)
        Me.datetrans.TabIndex = 151
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "Cashier ID"
        '
        'Refresh_btn
        '
        Me.Refresh_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Refresh_btn.Location = New System.Drawing.Point(426, 441)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.Refresh_btn.TabIndex = 147
        Me.Refresh_btn.Text = "Refresh"
        Me.Refresh_btn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(732, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Search"
        '
        'data
        '
        Me.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column6, Me.Column8, Me.Column3})
        Me.data.Location = New System.Drawing.Point(649, 93)
        Me.data.Name = "data"
        Me.data.RowHeadersVisible = False
        Me.data.Size = New System.Drawing.Size(390, 440)
        Me.data.TabIndex = 145
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Order No."
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 78
        '
        'Column1
        '
        Me.Column1.HeaderText = "Student Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cashier ID"
        Me.Column2.Name = "Column2"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Transact Date"
        Me.Column6.Name = "Column6"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Payment"
        Me.Column8.Name = "Column8"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Status"
        Me.Column3.Name = "Column3"
        '
        'search_box
        '
        Me.search_box.Location = New System.Drawing.Point(810, 46)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(214, 20)
        Me.search_box.TabIndex = 144
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete_btn.Location = New System.Drawing.Point(323, 441)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 143
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'updt_btn
        '
        Me.updt_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.updt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updt_btn.Location = New System.Drawing.Point(208, 441)
        Me.updt_btn.Name = "updt_btn"
        Me.updt_btn.Size = New System.Drawing.Size(75, 23)
        Me.updt_btn.TabIndex = 142
        Me.updt_btn.Text = "Update"
        Me.updt_btn.UseVisualStyleBackColor = False
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add_btn.Location = New System.Drawing.Point(99, 441)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 141
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Transact Date"
        '
        'stuid
        '
        Me.stuid.Location = New System.Drawing.Point(124, 93)
        Me.stuid.Name = "stuid"
        Me.stuid.Size = New System.Drawing.Size(88, 20)
        Me.stuid.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Student ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "First Name"
        '
        'cashfname
        '
        Me.cashfname.Location = New System.Drawing.Point(332, 326)
        Me.cashfname.Name = "cashfname"
        Me.cashfname.ReadOnly = True
        Me.cashfname.Size = New System.Drawing.Size(88, 20)
        Me.cashfname.TabIndex = 173
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(436, 328)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 18)
        Me.Label16.TabIndex = 174
        Me.Label16.Text = "Last Name"
        '
        'cashlname
        '
        Me.cashlname.Location = New System.Drawing.Point(538, 328)
        Me.cashlname.Name = "cashlname"
        Me.cashlname.ReadOnly = True
        Me.cashlname.Size = New System.Drawing.Size(88, 20)
        Me.cashlname.TabIndex = 175
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 18)
        Me.Label17.TabIndex = 176
        Me.Label17.Text = "Purchase No."
        '
        'purchasenum
        '
        Me.purchasenum.FormattingEnabled = True
        Me.purchasenum.Location = New System.Drawing.Point(143, 188)
        Me.purchasenum.Name = "purchasenum"
        Me.purchasenum.Size = New System.Drawing.Size(121, 21)
        Me.purchasenum.TabIndex = 177
        '
        'cashid
        '
        Me.cashid.Location = New System.Drawing.Point(123, 330)
        Me.cashid.Name = "cashid"
        Me.cashid.Size = New System.Drawing.Size(88, 20)
        Me.cashid.TabIndex = 178
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Order No."
        '
        'Orderno
        '
        Me.Orderno.Location = New System.Drawing.Point(413, 189)
        Me.Orderno.Name = "Orderno"
        Me.Orderno.ReadOnly = True
        Me.Orderno.Size = New System.Drawing.Size(88, 20)
        Me.Orderno.TabIndex = 180
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "Status"
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(116, 245)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(88, 20)
        Me.status.TabIndex = 182
        '
        'Pays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1059, 570)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Orderno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cashid)
        Me.Controls.Add(Me.purchasenum)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cashlname)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cashfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dept)
        Me.Controls.Add(Me.coursestud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.datetrans)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.updt_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.stuid)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Pays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pays"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dept As System.Windows.Forms.TextBox
    Friend WithEvents coursestud As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents datetrans As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents search_box As System.Windows.Forms.TextBox
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents updt_btn As System.Windows.Forms.Button
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stuid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cashfname As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cashlname As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents purchasenum As System.Windows.Forms.ComboBox
    Friend WithEvents cashid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Orderno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.TextBox
End Class
