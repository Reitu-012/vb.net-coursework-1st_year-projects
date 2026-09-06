Public Class frmEmptyArray
    Private ArrayMonths(11) As String
    Private cnt As Integer = 0
    Private Sub brnAdd_Click(sender As Object, e As EventArgs) Handles brnAdd.Click
        If cnt > 11 Then
            MessageBox.Show("Array is full", "Array is full", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ArrayMonths(cnt) = txtMonth.Text
        cnt = cnt + 1

        txtMonth.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer

        lsbIndex.Items.Clear()
        lsbValue.Items.Clear()

        For i = 0 To (cnt - 1)
            lsbIndex.Items.Add(i)
            lsbValue.Items.Add(ArrayMonths(i))
        Next

    End Sub
End Class