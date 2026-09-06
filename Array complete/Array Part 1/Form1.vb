Public Class Form1
    Private Sub DeclareArrayWithValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeclareArrayWithValuesToolStripMenuItem.Click
        Dim objArrayWiithValues As New frmArrayWithValues

        objArrayWiithValues.MdiParent = Me
        objArrayWiithValues.Show()
    End Sub

    Private Sub DeclareEmptyArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeclareEmptyArrayToolStripMenuItem.Click
        Dim objEmptyArray As New frmEmptyArray

        objEmptyArray.MdiParent = Me
        objEmptyArray.Show()
    End Sub
End Class
