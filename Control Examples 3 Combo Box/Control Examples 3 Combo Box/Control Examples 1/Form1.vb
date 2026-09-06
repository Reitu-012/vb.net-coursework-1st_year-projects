'Purpose: Allow the user to view the price per pizza as per the constant values
'Author:
'Date:

Option Strict On
Option Explicit On

Public Class Form1
    'constants for the whole class to use. Prices of the Pizza options:
    Const PRICE_MARGARITA As Decimal = 80D
    Const PRICE_MEATY As Decimal = 105.99D
    Const PRICE_CHICKEN As Decimal = 90.5D
    Const PRICE_PEPPERONI As Decimal = 125.5D
    Const PRICE_BARBEQUE As Decimal = 110.99D

    'constants for the whole class to use. Pizza options:
    Const TYPE_MARGARITA As Integer = 0
    Const TYPE_MEATY As Integer = 1
    Const TYPE_CHICKEN As Integer = 2
    Const TYPE_PEPPERONI As Integer = 3
    Const TYPE_BARBEQUE As Integer = 4


    Private Sub btnDisplayPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayPrice.Click
        Dim price As Decimal

        'Assign the price depending on the combo box selected



        'Display the price
        lblPrice.Text = price.ToString("C2")

    End Sub

   
End Class
