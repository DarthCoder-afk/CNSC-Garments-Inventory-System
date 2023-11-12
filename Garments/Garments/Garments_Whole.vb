Imports System.Windows.Forms

Public Class Garments_Whole

    Dim Products As New Products
    Dim Students As New Students
    Dim Cashier As New Cashier
    Dim Supplier As New Supplier
    Dim Staff As New Staff
    Dim Purchase As New Purchase
    Dim Checks As New Checks
    Dim Pays As New Pays
    Dim Supplies As New Supplies1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub dta_student_Click(sender As Object, e As EventArgs) Handles dta_student.Click

        ' Make it a child of this MDI form before showing it.
        Me.BackgroundImage = Nothing
        Students.MdiParent = Me
        Students.Show()
        Products.MdiParent = Me
        Products.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Staff.MdiParent = Me
        Staff.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Me.BackgroundImage = Nothing
        ' Make it a child of this MDI form before showing it.
        Products.MdiParent = Me
        Products.Show()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Staff.MdiParent = Me
        Staff.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
    End Sub

    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        Cashier.MdiParent = Me
        Cashier.Show()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Staff.MdiParent = Me
        Staff.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier.MdiParent = Me
        Supplier.Show()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Staff.MdiParent = Me
        Staff.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Staff.MdiParent = Me
        Staff.Show()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub Garments_Whole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        Purchase.MdiParent = Me
        Purchase.Show()
        Me.Size = New Size(Purchase.Width + 50, Purchase.Height + 50)

        Staff.MdiParent = Me
        Staff.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub ChecksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChecksToolStripMenuItem.Click
        Checks.MdiParent = Me
        Checks.Show()
        Me.Size = New Size(Checks.Width + 80, Checks.Height + 50)

        Staff.MdiParent = Me
        Staff.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Pays.MdiParent = Me
        Pays.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
        Me.BackgroundImage = Nothing

    End Sub

    Private Sub PaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaysToolStripMenuItem.Click
        Pays.MdiParent = Me
        Pays.Show()
        Me.Size = New Size(Pays.Width + 50, Pays.Height + 50)

        Staff.MdiParent = Me
        Staff.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Supplies.MdiParent = Me
        Supplies.Hide()
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub SuppliesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliesToolStripMenuItem.Click
        Supplies.MdiParent = Me
        Supplies.Show()
        Me.Size = New Size(Supplies.Width + 50, Supplies.Height + 50)
        Staff.MdiParent = Me
        Staff.Hide()
        Supplier.MdiParent = Me
        Supplier.Hide()
        Products.MdiParent = Me
        Products.Hide()
        Students.MdiParent = Me
        Students.Hide()
        Cashier.MdiParent = Me
        Cashier.Hide()
        Purchase.MdiParent = Me
        Purchase.Hide()
        Checks.MdiParent = Me
        Checks.Hide()
        Me.BackgroundImage = Nothing

    End Sub
End Class
