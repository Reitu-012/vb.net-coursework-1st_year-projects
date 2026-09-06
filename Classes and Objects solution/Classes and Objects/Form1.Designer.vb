<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        nudTest1 = New NumericUpDown()
        nudTest2 = New NumericUpDown()
        txtSurname = New TextBox()
        txtStudentNo = New TextBox()
        btnDiplayData = New Button()
        lblStudentData = New Label()
        CType(nudTest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTest2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 0
        Label1.Text = "Student No:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Surname:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 2
        Label3.Text = "Test 1:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 3
        Label4.Text = "Test 2:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 20)
        Label5.TabIndex = 4
        Label5.Text = "Student Data:"
        ' 
        ' nudTest1
        ' 
        nudTest1.Location = New Point(152, 84)
        nudTest1.Name = "nudTest1"
        nudTest1.Size = New Size(150, 27)
        nudTest1.TabIndex = 5
        ' 
        ' nudTest2
        ' 
        nudTest2.Location = New Point(152, 128)
        nudTest2.Name = "nudTest2"
        nudTest2.Size = New Size(150, 27)
        nudTest2.TabIndex = 6
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(152, 44)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(352, 27)
        txtSurname.TabIndex = 7
        ' 
        ' txtStudentNo
        ' 
        txtStudentNo.Location = New Point(152, 6)
        txtStudentNo.Name = "txtStudentNo"
        txtStudentNo.Size = New Size(352, 27)
        txtStudentNo.TabIndex = 8
        ' 
        ' btnDiplayData
        ' 
        btnDiplayData.Location = New Point(235, 201)
        btnDiplayData.Name = "btnDiplayData"
        btnDiplayData.Size = New Size(171, 52)
        btnDiplayData.TabIndex = 9
        btnDiplayData.Text = "Display Data"
        btnDiplayData.UseVisualStyleBackColor = True
        ' 
        ' lblStudentData
        ' 
        lblStudentData.AutoSize = True
        lblStudentData.BorderStyle = BorderStyle.Fixed3D
        lblStudentData.Location = New Point(152, 288)
        lblStudentData.Name = "lblStudentData"
        lblStudentData.Size = New Size(2, 22)
        lblStudentData.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 419)
        Controls.Add(lblStudentData)
        Controls.Add(btnDiplayData)
        Controls.Add(txtStudentNo)
        Controls.Add(txtSurname)
        Controls.Add(nudTest2)
        Controls.Add(nudTest1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "225229268 Reotshepile Reitumetse Rakhalakane"
        CType(nudTest1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTest2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nudTest1 As NumericUpDown
    Friend WithEvents nudTest2 As NumericUpDown
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents btnDiplayData As Button
    Friend WithEvents lblStudentData As Label

End Class
