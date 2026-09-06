Public Class Form1
    Private Sub btnDiplayData_Click(sender As Object, e As EventArgs) Handles btnDiplayData.Click
        Dim objStudent As New ClassStudents(txtStudentNo.Text, txtSurname.Text, nudTest1.Value, nudTest2.Value)

        lblStudentData.Text = objStudent.ToString
    End Sub
End Class
