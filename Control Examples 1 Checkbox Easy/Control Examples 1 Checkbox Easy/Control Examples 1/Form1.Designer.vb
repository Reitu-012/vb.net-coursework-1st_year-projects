<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnDisplayNumber = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkDoubleNumber = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnDisplayNumber
        '
        Me.btnDisplayNumber.Location = New System.Drawing.Point(16, 238)
        Me.btnDisplayNumber.Name = "btnDisplayNumber"
        Me.btnDisplayNumber.Size = New System.Drawing.Size(110, 62)
        Me.btnDisplayNumber.TabIndex = 0
        Me.btnDisplayNumber.Text = "Display Number"
        Me.btnDisplayNumber.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(157, 69)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number:"
        '
        'lblNumber
        '
        Me.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumber.Location = New System.Drawing.Point(154, 174)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(103, 29)
        Me.lblNumber.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(132, 238)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 62)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(248, 238)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 62)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkDoubleNumber
        '
        Me.chkDoubleNumber.AutoSize = True
        Me.chkDoubleNumber.Location = New System.Drawing.Point(157, 119)
        Me.chkDoubleNumber.Name = "chkDoubleNumber"
        Me.chkDoubleNumber.Size = New System.Drawing.Size(118, 17)
        Me.chkDoubleNumber.TabIndex = 10
        Me.chkDoubleNumber.Text = "Double the Number"
        Me.chkDoubleNumber.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 312)
        Me.Controls.Add(Me.chkDoubleNumber)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDisplayNumber)
        Me.Name = "Form1"
        Me.Text = "Easy example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplayNumber As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkDoubleNumber As System.Windows.Forms.CheckBox

End Class
