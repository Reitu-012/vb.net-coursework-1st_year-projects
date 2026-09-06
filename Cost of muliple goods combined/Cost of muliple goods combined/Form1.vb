Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1

    'Author: Reotshepile Reitumetse Rakhalakane 
    'Purpose: Calculate price of multiple singular items
    'Date: 26 April 2025

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtItemNo_TextChanged(sender As Object, e As EventArgs) Handles txtItemNo.TextChanged

    End Sub

    Private Sub lblItemNo_Click(sender As Object, e As EventArgs) Handles lblItemNo.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare Varibles
        Dim ItemNo As Integer
        Dim Price As Decimal
        Dim AmountDue As Decimal

        'Get input
        Integer.TryParse(txtItemNo.Text, ItemNo)
        Decimal.TryParse(txtPrice.Text, Price)

        'Calculate amount due
        AmountDue = Price * ItemNo

        'Display results
        lblAmount.Text = AmountDue.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAmount.Text = ""
        txtItemNo.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
