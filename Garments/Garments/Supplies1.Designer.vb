<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplies1
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
        Me.contactnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pidbox = New System.Windows.Forms.ComboBox()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.prodquant = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prodsize = New System.Windows.Forms.TextBox()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.updt_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.supid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.arrivaldate = New System.Windows.Forms.DateTimePicker()
        Me.data2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.transactno = New System.Windows.Forms.TextBox()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 26)
        Me.Label14.TabIndex = 167
        Me.Label14.Text = "Product"
        '
        'contactnum
        '
        Me.contactnum.Location = New System.Drawing.Point(546, 117)
        Me.contactnum.Name = "contactnum"
        Me.contactnum.ReadOnly = True
        Me.contactnum.Size = New System.Drawing.Size(88, 20)
        Me.contactnum.TabIndex = 162
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(435, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 18)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "Contact No."
        '
        'name
        '
        Me.name.Location = New System.Drawing.Point(300, 119)
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        Me.name.Size = New System.Drawing.Size(119, 20)
        Me.name.TabIndex = 160
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 26)
        Me.Label11.TabIndex = 159
        Me.Label11.Text = "Supplier Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(239, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Name"
        '
        'pidbox
        '
        Me.pidbox.FormattingEnabled = True
        Me.pidbox.Location = New System.Drawing.Point(134, 307)
        Me.pidbox.Name = "pidbox"
        Me.pidbox.Size = New System.Drawing.Size(121, 21)
        Me.pidbox.TabIndex = 157
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(408, 310)
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        Me.pname.Size = New System.Drawing.Size(216, 20)
        Me.pname.TabIndex = 156
        '
        'prodquant
        '
        Me.prodquant.Location = New System.Drawing.Point(283, 362)
        Me.prodquant.Name = "prodquant"
        Me.prodquant.Size = New System.Drawing.Size(39, 20)
        Me.prodquant.TabIndex = 153
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "Product ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Size"
        '
        'prodsize
        '
        Me.prodsize.Location = New System.Drawing.Point(79, 360)
        Me.prodsize.Name = "prodsize"
        Me.prodsize.ReadOnly = True
        Me.prodsize.Size = New System.Drawing.Size(99, 20)
        Me.prodsize.TabIndex = 148
        '
        'Refresh_btn
        '
        Me.Refresh_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Refresh_btn.Location = New System.Drawing.Point(451, 478)
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
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6})
        Me.data.Location = New System.Drawing.Point(649, 93)
        Me.data.Name = "data"
        Me.data.RowHeadersVisible = False
        Me.data.Size = New System.Drawing.Size(390, 186)
        Me.data.TabIndex = 145
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Transact No."
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 94
        '
        'Column1
        '
        Me.Column1.HeaderText = "Supplier ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Id"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Product Type"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Arrival Date"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Product Name"
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
        Me.delete_btn.Location = New System.Drawing.Point(344, 478)
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
        Me.updt_btn.Location = New System.Drawing.Point(229, 478)
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
        Me.add_btn.Location = New System.Drawing.Point(111, 478)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 141
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'supid
        '
        Me.supid.Location = New System.Drawing.Point(134, 117)
        Me.supid.Name = "supid"
        Me.supid.Size = New System.Drawing.Size(88, 20)
        Me.supid.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Supplier ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Arrival Date"
        '
        'arrivaldate
        '
        Me.arrivaldate.CustomFormat = "yyyy-MM-dd"
        Me.arrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.arrivaldate.Location = New System.Drawing.Point(145, 176)
        Me.arrivaldate.Name = "arrivaldate"
        Me.arrivaldate.Size = New System.Drawing.Size(149, 20)
        Me.arrivaldate.TabIndex = 173
        '
        'data2
        '
        Me.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.data2.Location = New System.Drawing.Point(649, 306)
        Me.data2.Name = "data2"
        Me.data2.RowHeadersVisible = False
        Me.data2.Size = New System.Drawing.Size(387, 234)
        Me.data2.TabIndex = 174
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stocks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Transact No."
        '
        'transactno
        '
        Me.transactno.Location = New System.Drawing.Point(438, 176)
        Me.transactno.Name = "transactno"
        Me.transactno.ReadOnly = True
        Me.transactno.Size = New System.Drawing.Size(88, 20)
        Me.transactno.TabIndex = 176
        '
        'Supplies1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1059, 570)
        Me.Controls.Add(Me.transactno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.data2)
        Me.Controls.Add(Me.arrivaldate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.contactnum)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pidbox)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.prodquant)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prodsize)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.updt_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.supid)
        Me.Controls.Add(Me.Label2)

        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Supplies"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents contactnum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents name As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pidbox As System.Windows.Forms.ComboBox
    Friend WithEvents pname As System.Windows.Forms.TextBox
    Friend WithEvents prodquant As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents prodsize As System.Windows.Forms.TextBox
    Friend WithEvents Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents search_box As System.Windows.Forms.TextBox
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents updt_btn As System.Windows.Forms.Button
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents supid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents arrivaldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents data2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents transactno As System.Windows.Forms.TextBox
End Class
