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

        'Double the number if needed
        If chkDoubleNumber.Checked = True Then
            number = number * 2
        End If

        'Display the number
        lblNumber.Text = number.ToString("N1")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber.Clear()
        lblNumber.Text = ""
        chkDoubleNumber.Checked = False

        txtNumber.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
