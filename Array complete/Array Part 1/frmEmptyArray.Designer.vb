<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmptyArray
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtMonth = New TextBox()
        brnAdd = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        lsbIndex = New ListBox()
        lsbValue = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter Month:"
        ' 
        ' txtMonth
        ' 
        txtMonth.Location = New Point(122, 20)
        txtMonth.Name = "txtMonth"
        txtMonth.Size = New Size(125, 27)
        txtMonth.TabIndex = 1
        ' 
        ' brnAdd
        ' 
        brnAdd.Location = New Point(318, 20)
        brnAdd.Name = "brnAdd"
        brnAdd.Size = New Size(188, 29)
        brnAdd.TabIndex = 2
        brnAdd.Text = "Add Month in Array"
        brnAdd.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(11, 81)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 29)
        Button1.TabIndex = 3
        Button1.Text = "Show New Array"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 4
        Label2.Text = "Index:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(182, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 5
        Label3.Text = "Values:"
        ' 
        ' lsbIndex
        ' 
        lsbIndex.FormattingEnabled = True
        lsbIndex.Location = New Point(12, 166)
        lsbIndex.Name = "lsbIndex"
        lsbIndex.Size = New Size(105, 244)
        lsbIndex.TabIndex = 6
        ' 
        ' lsbValue
        ' 
        lsbValue.FormattingEnabled = True
        lsbValue.Location = New Point(182, 166)
        lsbValue.Name = "lsbValue"
        lsbValue.Size = New Size(165, 244)
        lsbValue.TabIndex = 7
        ' 
        ' frmEmptyArray
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lsbValue)
        Controls.Add(lsbIndex)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(brnAdd)
        Controls.Add(txtMonth)
        Controls.Add(Label1)
        Name = "frmEmptyArray"
        Text = "frmEmptyArray"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents brnAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lsbIndex As ListBox
    Friend WithEvents lsbValue As ListBox
End Class
