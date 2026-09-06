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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNewInsert = New System.Windows.Forms.Label()
        Me.txtInsert = New System.Windows.Forms.TextBox()
        Me.nudIndex = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Contains = New System.Windows.Forms.GroupBox()
        Me.txtContains = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnContain = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtIndexof = New System.Windows.Forms.TextBox()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnIndex = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblNewSubstring = New System.Windows.Forms.Label()
        Me.nmuNumberCharSubstring = New System.Windows.Forms.NumericUpDown()
        Me.nmuStartIndex = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSubstring = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nudStartIndexRemove = New System.Windows.Forms.NumericUpDown()
        Me.nudNumberofCharRemove = New System.Windows.Forms.NumericUpDown()
        Me.lblRemove = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.lblNewReplace = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contains.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nmuNumberCharSubstring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmuStartIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudStartIndexRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberofCharRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter String:"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(127, 7)
        Me.txtString.Margin = New System.Windows.Forms.Padding(4)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(789, 22)
        Me.txtString.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLength)
        Me.GroupBox1.Controls.Add(Me.btnLength)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Length"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength.Location = New System.Drawing.Point(107, 73)
        Me.lblLength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(2, 18)
        Me.lblLength.TabIndex = 2
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(8, 23)
        Me.btnLength.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(100, 28)
        Me.btnLength.TabIndex = 1
        Me.btnLength.Text = "Get Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Length:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNewInsert)
        Me.GroupBox2.Controls.Add(Me.txtInsert)
        Me.GroupBox2.Controls.Add(Me.nudIndex)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnInsert)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(320, 190)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insert"
        '
        'lblNewInsert
        '
        Me.lblNewInsert.AutoSize = True
        Me.lblNewInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewInsert.Location = New System.Drawing.Point(161, 150)
        Me.lblNewInsert.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewInsert.Name = "lblNewInsert"
        Me.lblNewInsert.Size = New System.Drawing.Size(2, 18)
        Me.lblNewInsert.TabIndex = 6
        '
        'txtInsert
        '
        Me.txtInsert.Location = New System.Drawing.Point(165, 106)
        Me.txtInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(119, 22)
        Me.txtInsert.TabIndex = 5
        '
        'nudIndex
        '
        Me.nudIndex.Location = New System.Drawing.Point(165, 64)
        Me.nudIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.nudIndex.Name = "nudIndex"
        Me.nudIndex.Size = New System.Drawing.Size(71, 22)
        Me.nudIndex.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "New String:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Text to Insert:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Start Index:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(8, 23)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 28)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Contains
        '
        Me.Contains.Controls.Add(Me.txtContains)
        Me.Contains.Controls.Add(Me.Label6)
        Me.Contains.Controls.Add(Me.btnContain)
        Me.Contains.Location = New System.Drawing.Point(19, 259)
        Me.Contains.Margin = New System.Windows.Forms.Padding(4)
        Me.Contains.Name = "Contains"
        Me.Contains.Padding = New System.Windows.Forms.Padding(4)
        Me.Contains.Size = New System.Drawing.Size(311, 134)
        Me.Contains.TabIndex = 7
        Me.Contains.TabStop = False
        Me.Contains.Text = "Contains"
        '
        'txtContains
        '
        Me.txtContains.Location = New System.Drawing.Point(133, 63)
        Me.txtContains.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContains.Name = "txtContains"
        Me.txtContains.Size = New System.Drawing.Size(132, 22)
        Me.txtContains.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Contains Text:"
        '
        'btnContain
        '
        Me.btnContain.Location = New System.Drawing.Point(19, 23)
        Me.btnContain.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContain.Name = "btnContain"
        Me.btnContain.Size = New System.Drawing.Size(100, 28)
        Me.btnContain.TabIndex = 0
        Me.btnContain.Text = "Contain"
        Me.btnContain.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtIndexof)
        Me.GroupBox3.Controls.Add(Me.lblIndex)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnIndex)
        Me.GroupBox3.Location = New System.Drawing.Point(679, 49)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(375, 178)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Index of"
        '
        'txtIndexof
        '
        Me.txtIndexof.Location = New System.Drawing.Point(188, 64)
        Me.txtIndexof.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIndexof.Name = "txtIndexof"
        Me.txtIndexof.Size = New System.Drawing.Size(132, 22)
        Me.txtIndexof.TabIndex = 4
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndex.Location = New System.Drawing.Point(184, 114)
        Me.lblIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(2, 18)
        Me.lblIndex.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Found at index:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Found index of:"
        '
        'btnIndex
        '
        Me.btnIndex.Location = New System.Drawing.Point(8, 23)
        Me.btnIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIndex.Name = "btnIndex"
        Me.btnIndex.Size = New System.Drawing.Size(100, 28)
        Me.btnIndex.TabIndex = 0
        Me.btnIndex.Text = "Index"
        Me.btnIndex.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblNewSubstring)
        Me.GroupBox4.Controls.Add(Me.nmuNumberCharSubstring)
        Me.GroupBox4.Controls.Add(Me.nmuStartIndex)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.btnSubstring)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 447)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(307, 195)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Substring"
        '
        'lblNewSubstring
        '
        Me.lblNewSubstring.AutoSize = True
        Me.lblNewSubstring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewSubstring.Location = New System.Drawing.Point(145, 158)
        Me.lblNewSubstring.Name = "lblNewSubstring"
        Me.lblNewSubstring.Size = New System.Drawing.Size(2, 18)
        Me.lblNewSubstring.TabIndex = 7
        '
        'nmuNumberCharSubstring
        '
        Me.nmuNumberCharSubstring.Location = New System.Drawing.Point(171, 102)
        Me.nmuNumberCharSubstring.Name = "nmuNumberCharSubstring"
        Me.nmuNumberCharSubstring.Size = New System.Drawing.Size(120, 22)
        Me.nmuNumberCharSubstring.TabIndex = 6
        '
        'nmuStartIndex
        '
        Me.nmuStartIndex.Location = New System.Drawing.Point(145, 57)
        Me.nmuStartIndex.Name = "nmuStartIndex"
        Me.nmuStartIndex.Size = New System.Drawing.Size(120, 22)
        Me.nmuStartIndex.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "New string:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Number of characters:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Start index:"
        '
        'btnSubstring
        '
        Me.btnSubstring.Location = New System.Drawing.Point(15, 21)
        Me.btnSubstring.Name = "btnSubstring"
        Me.btnSubstring.Size = New System.Drawing.Size(75, 23)
        Me.btnSubstring.TabIndex = 0
        Me.btnSubstring.Text = "Get substring"
        Me.btnSubstring.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblRemove)
        Me.GroupBox5.Controls.Add(Me.nudNumberofCharRemove)
        Me.GroupBox5.Controls.Add(Me.nudStartIndexRemove)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(380, 259)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(353, 211)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Remove"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Start Index:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Number of Characters:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "New String:"
        '
        'nudStartIndexRemove
        '
        Me.nudStartIndexRemove.Location = New System.Drawing.Point(149, 76)
        Me.nudStartIndexRemove.Name = "nudStartIndexRemove"
        Me.nudStartIndexRemove.Size = New System.Drawing.Size(120, 22)
        Me.nudStartIndexRemove.TabIndex = 14
        '
        'nudNumberofCharRemove
        '
        Me.nudNumberofCharRemove.Location = New System.Drawing.Point(188, 116)
        Me.nudNumberofCharRemove.Name = "nudNumberofCharRemove"
        Me.nudNumberofCharRemove.Size = New System.Drawing.Size(120, 22)
        Me.nudNumberofCharRemove.TabIndex = 15
        '
        'lblRemove
        '
        Me.lblRemove.AutoSize = True
        Me.lblRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemove.Location = New System.Drawing.Point(146, 164)
        Me.lblRemove.Name = "lblRemove"
        Me.lblRemove.Size = New System.Drawing.Size(2, 18)
        Me.lblRemove.TabIndex = 16
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblNewReplace)
        Me.GroupBox6.Controls.Add(Me.txtNew)
        Me.GroupBox6.Controls.Add(Me.txtOld)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.btnReplace)
        Me.GroupBox6.Location = New System.Drawing.Point(779, 259)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(376, 211)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Replace"
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(6, 35)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 0
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 16)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Old characters to replace:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(173, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Replace with new character:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "New String:"
        '
        'txtOld
        '
        Me.txtOld.Location = New System.Drawing.Point(227, 116)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.Size = New System.Drawing.Size(100, 22)
        Me.txtOld.TabIndex = 4
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(227, 70)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(100, 22)
        Me.txtNew.TabIndex = 5
        '
        'lblNewReplace
        '
        Me.lblNewReplace.AutoSize = True
        Me.lblNewReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewReplace.Location = New System.Drawing.Point(150, 154)
        Me.lblNewReplace.Name = "lblNewReplace"
        Me.lblNewReplace.Size = New System.Drawing.Size(2, 18)
        Me.lblNewReplace.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 757)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Contains)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contains.ResumeLayout(False)
        Me.Contains.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nmuNumberCharSubstring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmuStartIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudStartIndexRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberofCharRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtString As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblLength As Label
    Friend WithEvents btnLength As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents lblNewInsert As Label
    Friend WithEvents txtInsert As TextBox
    Friend WithEvents nudIndex As NumericUpDown
    Friend WithEvents Contains As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnContain As Button
    Friend WithEvents txtContains As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtIndexof As TextBox
    Friend WithEvents lblIndex As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnIndex As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSubstring As Button
    Friend WithEvents lblNewSubstring As Label
    Friend WithEvents nmuNumberCharSubstring As NumericUpDown
    Friend WithEvents nmuStartIndex As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblRemove As Label
    Friend WithEvents nudNumberofCharRemove As NumericUpDown
    Friend WithEvents nudStartIndexRemove As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnReplace As Button
    Friend WithEvents lblNewReplace As Label
    Friend WithEvents txtNew As TextBox
    Friend WithEvents txtOld As TextBox
End Class
