Public Class Form1

    Private Sub EnterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterDataToolStripMenuItem.Click
        Dim objEnterData As New frmEnterData

        objEnterData.MdiParent = Me
        objEnterData.Show()
    End Sub

    Private Sub ViewDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDataToolStripMenuItem.Click
        Dim objViewData As New frmViewData

        objViewData.MdiParent = Me
        objViewData.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
