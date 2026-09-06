'Purpose: Use a check box to get input
'Author:
'Date:

Option Strict On
Option Explicit On

Public Class Form1

    Private Sub btnDisplayNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayNumber.Click
        'Declare the variables
        Dim number As Double

        'Get the number
        number = CDbl(txtNumber.Text)

        'Test the radio buttons for the calculation
        If rdoDouble.Checked = True Then
            number = number * 2
        ElseIf rdoHalf.Checked = True Then
            number = number / 2
        ElseIf rdoTripple.Checked = True Then
            number = number * 3
        ElseIf rdoLeave.Checked Then
            'do nothing to the number
        End If

        'Display the number
        lblNumber.Text = number.ToString("N1")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber.Clear()
        lblNumber.Text = ""
        rdoDouble.Checked = True

        txtNumber.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
