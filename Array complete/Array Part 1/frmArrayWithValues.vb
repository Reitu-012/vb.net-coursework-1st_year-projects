Public Class frmArrayWithValues
    Private ArrayMonths() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug"}

    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim i As Integer
        Dim cnt As Integer

        cnt = ArrayMonths.Count

        For i = 0 To (cnt - 1)
            lsbIndex.Items.Add(i)
            lsbValues.Items.Add(ArrayMonths(i))
        Next
    End Sub
End Class