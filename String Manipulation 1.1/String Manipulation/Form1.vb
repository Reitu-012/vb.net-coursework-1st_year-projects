Public Class Form1
    Private Sub btnCharacterArray_Click(sender As Object, e As EventArgs) Handles btnCharacterArray.Click

        Dim myString As String
        Dim arraychar() As Char
        Dim myarraycount As Integer
        Dim i As Integer

        myString = txtString.Text

        arraychar = myString.ToCharArray

        myarraycount = arraychar.Count

        lsbChars.Items.Clear()

        For i = 0 To myarraycount - 1
            lsbChars.Items.Add(i & "->" & arraychar(i))

        Next
    End Sub

    Private Sub btnRandomNumber_Click(sender As Object, e As EventArgs) Handles btnRandomNumber.Click
        Dim Ra As New Random
        Dim myrandomnumber As Integer

        myrandomnumber = Ra.Next(nudMinimumValue.Value, nudMaximumValue.Value)

        lblRandomNumber.Text = myrandomnumber.ToString

    End Sub
End Class
