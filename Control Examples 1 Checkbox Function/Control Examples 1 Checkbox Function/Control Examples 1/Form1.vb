'Purpose: Allow the user to order Pizzas
'Each Pizza costs R80.  Extra cheese is R5 per pizza
'Author:
'Date:

Option Strict On
Option Explicit On

Public Class Form1

    'Purpose: Return the price of a pizza(including extra cheese)
    'Each Pizza costs R80.  Extra cheese is R5 per pizza
    'Receive: boolean extra cheese, qty of pizzaseturn: Price
    Private Function CalcPrice(ByVal ExtraCheese As Boolean, ByVal qty As Integer) As Decimal
        Const PIZZA_PRICE As Decimal = 80D
        Const EXTRA_CHEESE_PRICE As Decimal = 5D
        Dim Price As Decimal



        Return Price
    End Function


    Private Sub btnDisplayPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayPrice.Click
        Dim PizzaName As String
        Dim Qty As Integer
        Dim Price As Decimal

        'Get the input
        PizzaName = txtPizzaName.Text
        Qty = CInt(txtQty.Text)


        'Calculate the price(including extra cheese) (call the function)


        'Display the price
        lblPrice.Text = Price.ToString

    End Sub
End Class
