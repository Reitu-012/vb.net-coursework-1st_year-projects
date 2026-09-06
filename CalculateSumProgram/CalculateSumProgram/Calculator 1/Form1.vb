'Program: Calculate the sum of two numbers
'Author: Mrs S Ribeiro
'Date: 30 March

Option Strict On
Option Explicit On

Public Class frmMain

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Define the variables
        Dim num1, num2, sum As Double

        'Get the input
        num1 = CDbl(txtNum1.Text)
        num2 = CDbl(txtNum1.Text)

        'Calculate the sum
        sum = num1 + num2

        'Display the output
        lblSum.Text = sum.ToString("N1")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Clear()
        txtNum2.Clear()
        lblSum.Text = ""
        txtNum1.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
