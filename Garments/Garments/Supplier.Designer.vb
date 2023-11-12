<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.updt_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.supp_name = New System.Windows.Forms.TextBox()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Refresh_btn
        '
        Me.Refresh_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Refresh_btn.Location = New System.Drawing.Point(159, 362)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.Refresh_btn.TabIndex = 80
        Me.Refresh_btn.Text = "Refresh"
        Me.Refresh_btn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(454, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Search"
        '
        'data
        '
        Me.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.data.Location = New System.Drawing.Point(446, 167)
        Me.data.Name = "data"
        Me.data.RowHeadersVisible = False
        Me.data.Size = New System.Drawing.Size(299, 234)
        Me.data.TabIndex = 78
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Supplier"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Contact_num"
        Me.Column3.Name = "Column3"
        '
        'search_box
        '
        Me.search_box.Location = New System.Drawing.Point(522, 122)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(214, 20)
        Me.search_box.TabIndex = 77
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete_btn.Location = New System.Drawing.Point(273, 307)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 76
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'updt_btn
        '
        Me.updt_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.updt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updt_btn.Location = New System.Drawing.Point(159, 307)
        Me.updt_btn.Name = "updt_btn"
        Me.updt_btn.Size = New System.Drawing.Size(75, 23)
        Me.updt_btn.TabIndex = 75
        Me.updt_btn.Text = "Update"
        Me.updt_btn.UseVisualStyleBackColor = False
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add_btn.Location = New System.Drawing.Point(35, 307)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 74
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(132, 255)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(216, 20)
        Me.contact.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Name"
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(132, 167)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(216, 20)
        Me.sid.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 26)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Contact No."
        '
        'supp_name
        '
        Me.supp_name.Location = New System.Drawing.Point(132, 210)
        Me.supp_name.Name = "supp_name"
        Me.supp_name.Size = New System.Drawing.Size(216, 20)
        Me.supp_name.TabIndex = 71
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(793, 553)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.updt_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.supp_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents search_box As System.Windows.Forms.TextBox
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents updt_btn As System.Windows.Forms.Button
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents contact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents supp_name As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
