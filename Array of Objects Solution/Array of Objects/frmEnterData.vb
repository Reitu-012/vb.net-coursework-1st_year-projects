Public Class frmEnterData

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim objCustomer As New ClassCustomer(txtID.Text, txtFullname.Text, nudUnitsUsed.Value)

        If cnt < 20 Then
            arrCustomers(cnt) = objCustomer
            cnt += 1

            ClearForm()
        Else
            MessageBox.Show("Array is full", "Full", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub ClearForm()
        txtID.Clear()
        txtFullname.Clear()
        nudUnitsUsed.Value = 0
    End Sub
End Class