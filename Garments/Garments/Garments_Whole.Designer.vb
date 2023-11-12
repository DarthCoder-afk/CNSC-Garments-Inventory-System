<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Garments_Whole
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Garments_Whole))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.dta_student = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChecksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuppliesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dta_student, Me.ProductToolStripMenuItem, Me.CashierToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.StaffToolStripMenuItem, Me.TransactionsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(809, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'dta_student
        '
        Me.dta_student.Name = "dta_student"
        Me.dta_student.Size = New System.Drawing.Size(60, 20)
        Me.dta_student.Text = "Student"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'CashierToolStripMenuItem
        '
        Me.CashierToolStripMenuItem.Name = "CashierToolStripMenuItem"
        Me.CashierToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CashierToolStripMenuItem.Text = "Cashier"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseToolStripMenuItem, Me.PaysToolStripMenuItem, Me.ChecksToolStripMenuItem, Me.SuppliesToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'PaysToolStripMenuItem
        '
        Me.PaysToolStripMenuItem.Name = "PaysToolStripMenuItem"
        Me.PaysToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PaysToolStripMenuItem.Text = "Pays"
        '
        'ChecksToolStripMenuItem
        '
        Me.ChecksToolStripMenuItem.Name = "ChecksToolStripMenuItem"
        Me.ChecksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChecksToolStripMenuItem.Text = "Checks"
        '
        'SuppliesToolStripMenuItem
        '
        Me.SuppliesToolStripMenuItem.Name = "SuppliesToolStripMenuItem"
        Me.SuppliesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuppliesToolStripMenuItem.Text = "Supplies"
        '
        'Garments_Whole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(809, 592)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Garments_Whole"
        Me.Text = "Garments_Whole"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dta_student As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChecksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
