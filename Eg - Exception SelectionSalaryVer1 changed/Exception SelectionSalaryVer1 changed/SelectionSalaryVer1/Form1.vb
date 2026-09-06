'Program: Selection Salary - version 1
'Author: [to enter]
'Date: [to enter]

Option Strict On
Option Explicit On

Public Class Form1
    Const dblNORMAL_HOURS As Double = 40

    'purpose: Get the input
    'Receive: none
    'Return: surname, hours, rate
    Private Sub AcceptEmployee(ByRef strSurname As String, ByRef dblHours As Double, ByRef decRate As Decimal)
        strSurname = txtSurname.Text
        dblHours = CDbl(txtHours.Text)
        decRate = CDec(txtRate.Text)
    End Sub

    'purpose: Calculate the overtime hours
    'Receive: hours
    'Return: overtime hours
    Private Function CalcOvertimeHours(ByVal dblHours As Double) As Double

        Dim dblOvertime As Double

        If dblHours > dblNORMAL_HOURS Then
            dblOvertime = dblHours - dblNORMAL_HOURS
        Else
            dblOvertime = 0
        End If

        Return dblOvertime
    End Function

    'purpose: Calculate the pay
    'Receive: hours, overtimehours, rate
    'Return: pay
    Private Function CalcPay(ByVal dblHours As Double, ByVal dblOvertimeHours As Double, ByVal decRate As Decimal) As Decimal
        Dim decPay As Decimal

        If dblHours > dblNORMAL_HOURS Then
            decPay = CDec(dblNORMAL_HOURS * decRate + dblOvertimeHours * decRate * 2)
        Else
            decPay = CDec(dblHours * decRate)
        End If

        Return decPay
    End Function


    'Purpose: Display the output
    'Receive: surname, overtime hours, pay
    'Return: none
    Private Sub DisplayPay(ByVal strSurname As String, ByVal dblOvertimeHours As Double, ByVal decPay As Decimal)

        lblOutput.Text = "********* Employee **********" & ControlChars.NewLine _
        & "Surname:" & strSurname & ControlChars.NewLine _
        & "Overtime hours:" & dblOvertimeHours.ToString("N1") & ControlChars.NewLine _
        & "Pay:" & decPay.ToString("C2") & ControlChars.NewLine _
        & "********************************************"

    End Sub

    'Steps:
    '1. get the input
    '2. calculate the overtime hours
    '3. calculate the pay
    '4. display the output
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim strSurname As String = ""
        Dim dblHours, dblOvertime As Double
        Dim decRate As Decimal
        Dim decPay As Decimal

        Try
            AcceptEmployee(strSurname, dblHours, decRate)
            dblOvertime = CalcOvertimeHours(dblHours)
            decPay = CalcPay(dblHours, dblOvertime, decRate)
            DisplayPay(strSurname, dblOvertime, decPay)

        Catch ex As Exception

            MessageBox.Show("The hours or Rate was invalid.  Please re-enter")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtHours.Clear()
        txtRate.Clear()
        txtSurname.Clear()
        lblOutput.Text = ""

        txtSurname.Focus()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
