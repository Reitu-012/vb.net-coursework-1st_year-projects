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
        txtString = New TextBox()
        GroupBox1 = New GroupBox()
        lsbChars = New ListBox()
        btnCharacterArray = New Button()
        GroupBox2 = New GroupBox()
        btnRandomNumber = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        nudMinimumValue = New NumericUpDown()
        nudMaximumValue = New NumericUpDown()
        lblRandomNumber = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(nudMinimumValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMaximumValue, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter String: "
        ' 
        ' txtString
        ' 
        txtString.Location = New Point(132, 6)
        txtString.Name = "txtString"
        txtString.Size = New Size(507, 27)
        txtString.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lsbChars)
        GroupBox1.Controls.Add(btnCharacterArray)
        GroupBox1.Location = New Point(12, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 665)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Character Array"
        ' 
        ' lsbChars
        ' 
        lsbChars.FormattingEnabled = True
        lsbChars.Location = New Point(6, 73)
        lsbChars.Name = "lsbChars"
        lsbChars.Size = New Size(150, 564)
        lsbChars.TabIndex = 1
        ' 
        ' btnCharacterArray
        ' 
        btnCharacterArray.Location = New Point(6, 26)
        btnCharacterArray.Name = "btnCharacterArray"
        btnCharacterArray.Size = New Size(220, 29)
        btnCharacterArray.TabIndex = 0
        btnCharacterArray.Text = "Character Array"
        btnCharacterArray.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblRandomNumber)
        GroupBox2.Controls.Add(nudMaximumValue)
        GroupBox2.Controls.Add(nudMinimumValue)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnRandomNumber)
        GroupBox2.Location = New Point(314, 56)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(387, 252)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Random Number"
        ' 
        ' btnRandomNumber
        ' 
        btnRandomNumber.Location = New Point(15, 26)
        btnRandomNumber.Name = "btnRandomNumber"
        btnRandomNumber.Size = New Size(214, 29)
        btnRandomNumber.TabIndex = 0
        btnRandomNumber.Text = "Get Random Number"
        btnRandomNumber.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 1
        Label2.Text = "Minimum Value:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 20)
        Label3.TabIndex = 2
        Label3.Text = "Maximum Value:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 20)
        Label4.TabIndex = 3
        Label4.Text = " Random Number:"
        ' 
        ' nudMinimumValue
        ' 
        nudMinimumValue.Location = New Point(204, 71)
        nudMinimumValue.Name = "nudMinimumValue"
        nudMinimumValue.Size = New Size(150, 27)
        nudMinimumValue.TabIndex = 4
        ' 
        ' nudMaximumValue
        ' 
        nudMaximumValue.Location = New Point(204, 134)
        nudMaximumValue.Name = "nudMaximumValue"
        nudMaximumValue.Size = New Size(150, 27)
        nudMaximumValue.TabIndex = 5
        ' 
        ' lblRandomNumber
        ' 
        lblRandomNumber.AutoSize = True
        lblRandomNumber.BorderStyle = BorderStyle.FixedSingle
        lblRandomNumber.Location = New Point(204, 197)
        lblRandomNumber.Name = "lblRandomNumber"
        lblRandomNumber.Size = New Size(2, 22)
        lblRandomNumber.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 742)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtString)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "225229268"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(nudMinimumValue, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMaximumValue, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtString As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lsbChars As ListBox
    Friend WithEvents btnCharacterArray As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudMinimumValue As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRandomNumber As Button
    Friend WithEvents lblRandomNumber As Label
    Friend WithEvents nudMaximumValue As NumericUpDown

End Class
