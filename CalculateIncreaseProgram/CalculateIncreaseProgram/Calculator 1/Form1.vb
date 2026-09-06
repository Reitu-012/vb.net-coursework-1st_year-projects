'Purpose: Increase an amount by a given percentage
'Authro: Mrs S Ribeiro
'Date: 7 March 

Option Strict On
Option Explicit On

Public Class frmMain

    'Purpose: Calculate the increased amount
    'Receive: amount, percent
    'Return: increased amount
    Private Function CalculateIncrease(ByVal Amount As Decimal, ByVal Percent As Decimal) As Decimal
        Dim IncreasedAmount As Decimal
        Dim PercentageAmount As Decimal

        PercentageAmount = Amount * Percent / 100
        IncreasedAmount = Amount + PercentageAmount

        Return IncreasedAmount
    End Function

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare the variables
        Dim Amount As Decimal
        Dim Percent As Decimal
        Dim IncreasedAmount As Decimal

        'Get the input
        Amount = CDec(txtAmount.Text)
        Percent = CDec(txtPercent.Text)

        'Call the function to calculate the increased amount
        IncreasedAmount = CalculateIncrease(Amount, Percent)

        'Display the output
        lblIncreaseAmount.Text = IncreasedAmount.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtPercent.Clear()
        lblIncreaseAmount.Text = ""
        txtAmount.Focus()
    End Sub
End Class
