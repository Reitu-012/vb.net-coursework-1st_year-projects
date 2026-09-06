Public Class frmViewData
    Private Sub GetCustomers()
        Dim i As Integer

        cmbCustomer.Items.Clear()

        For i = 0 To (cnt - 1)
            cmbCustomer.Items.Add(arrCustomers(i).FullName)
        Next
    End Sub

    Private Sub frmViewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCustomers()
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        lblID.Text = arrCustomers(cmbCustomer.SelectedIndex).IDnumber
        txtUnitsUsed.Text = arrCustomers(cmbCustomer.SelectedIndex).UnitUsed
        lblAmountDue.Text = arrCustomers(cmbCustomer.SelectedIndex).CalcPayment.ToString("F2")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        arrCustomers(cmbCustomer.SelectedIndex).UnitUsed = CInt(txtUnitsUsed.Text)

        lblAmountDue.Text = arrCustomers(cmbCustomer.SelectedIndex).CalcPayment.ToString("F2")
    End Sub
End Class