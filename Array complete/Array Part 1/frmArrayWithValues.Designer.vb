<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayWithValues
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
        btnArray = New Button()
        lsbIndex = New ListBox()
        lsbValues = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnArray
        ' 
        btnArray.Location = New Point(31, 29)
        btnArray.Name = "btnArray"
        btnArray.Size = New Size(199, 29)
        btnArray.TabIndex = 0
        btnArray.Text = "Show Array Values"
        btnArray.UseVisualStyleBackColor = True
        ' 
        ' lsbIndex
        ' 
        lsbIndex.FormattingEnabled = True
        lsbIndex.Location = New Point(30, 113)
        lsbIndex.Name = "lsbIndex"
        lsbIndex.Size = New Size(158, 224)
        lsbIndex.TabIndex = 1
        ' 
        ' lsbValues
        ' 
        lsbValues.FormattingEnabled = True
        lsbValues.Location = New Point(234, 113)
        lsbValues.Name = "lsbValues"
        lsbValues.Size = New Size(159, 224)
        lsbValues.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 20)
        Label1.TabIndex = 3
        Label1.Text = "Index:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 4
        Label2.Text = "Values:"
        ' 
        ' frmArrayWithValues
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lsbValues)
        Controls.Add(lsbIndex)
        Controls.Add(btnArray)
        Name = "frmArrayWithValues"
        Text = "frmArrayWithValues"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnArray As Button
    Friend WithEvents lsbIndex As ListBox
    Friend WithEvents lsbValues As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
