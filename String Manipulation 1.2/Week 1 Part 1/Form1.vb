Public Class Form1
    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        Dim myString As String
        Dim intLength As Integer

        myString = txtString.Text

        intLength = myString.Length

        lblLength.Text = intLength.ToString

        If intLength > 10 Then
            MessageBox.Show("The Length is greater than 10", "Gretaer than 10", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The Length is less than 11 characters", "Less than 11", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim myString As String
        Dim myNewString As String

        myString = txtString.Text

        myNewString = myString.Insert(nudIndex.Value, txtInsert.Text)

        lblNewInsert.Text = myNewString
    End Sub

    Private Sub btnContain_Click(sender As Object, e As EventArgs) Handles btnContain.Click
        Dim myString As String
        Dim myContains As String

        myString = txtString.Text
        myContains = txtContains.Text

        If myString.Contains(myContains) Then
            MessageBox.Show(myString & " contains " & myContains, " Contains ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(myString & " DOES NOT CONTAIN " & myContains, " Contains ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnIndex_Click(sender As Object, e As EventArgs) Handles btnIndex.Click
        Dim myString As String
        Dim myIndexof As String
        Dim myIndexfound As Integer

        myString = txtString.Text
        myIndexof = txtIndexof.Text

        myIndexfound = myString.IndexOf(myIndexof)

        lblIndex.Text = myIndexfound.ToString

        If myIndexfound = -1 Then
            MessageBox.Show(myIndexof & " does not exist in " & myString, " Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(myIndexof & " was found in " & myString, "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSubstring_Click(sender As Object, e As EventArgs) Handles btnSubstring.Click

        Dim myString As String
        Dim myStartIndex As Integer
        Dim myNumberChar As Integer
        Dim myNewString As String

        myString = txtString.Text
        myStartIndex = nmuStartIndex.Value
        myNumberChar = nmuNumberCharSubstring.Value

        If myNumberChar = 0 Then
            myNewString = myString.Substring(myStartIndex)
        Else
            myNewString = myString.Substring(myStartIndex, myNumberChar)
        End If

        lblNewSubstring.Text = myNewString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myString As String
        Dim myStartIndex As Integer
        Dim myNumberCharRemove As Integer
        Dim myNewString As String

        myString = txtString.Text
        myStartIndex = nudStartIndexRemove.Value
        myNumberCharRemove = nudNumberofCharRemove.Value

        If myNumberCharRemove = 0 Then
            myNewString = myString.Remove(myStartIndex)
        Else
            myNewString = myString.Remove(myStartIndex, myNumberCharRemove)
        End If

        lblRemove.Text = myNewString

        MessageBox.Show(myString)


    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click

        Dim myString As String
        Dim myOldChar As String
        Dim myNewChar As String
        Dim mynewstring As String

        myString = txtString.Text
        myOldChar = txtNew.Text
        mynewstring = txtOld.Text

        mynewstring = myString.Replace(myOldChar, mynewstring)

        lblNewReplace.Text = mynewstring

    End Sub
End Class
