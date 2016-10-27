<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DialogueButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HexKeyPanel = New System.Windows.Forms.Panel()
        Me.BReset = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BF = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.BE = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.BD = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.BC = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.BB = New System.Windows.Forms.Button()
        Me.B0 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.BA = New System.Windows.Forms.Button()
        Me.KeyDownAssist = New System.Windows.Forms.Button()
        Me.BSubmit = New System.Windows.Forms.Button()
        Me.NavButton2 = New Game_Project.NavButton()
        Me.NavButton4 = New Game_Project.NavButton()
        Me.NavButton3 = New Game_Project.NavButton()
        Me.NavButton1 = New Game_Project.NavButton()
        Me.Panel1.SuspendLayout()
        Me.HexKeyPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "I - Move up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "J - Move west"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "K - Move down"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "L - Move East"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DialogueButton)
        Me.Panel1.Controls.Add(Me.NavButton2)
        Me.Panel1.Controls.Add(Me.NavButton4)
        Me.Panel1.Controls.Add(Me.NavButton1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.NavButton3)
        Me.Panel1.Location = New System.Drawing.Point(180, 240)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 240)
        Me.Panel1.TabIndex = 5
        '
        'DialogueButton
        '
        Me.DialogueButton.Location = New System.Drawing.Point(407, 186)
        Me.DialogueButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DialogueButton.Name = "DialogueButton"
        Me.DialogueButton.Size = New System.Drawing.Size(30, 30)
        Me.DialogueButton.TabIndex = 6
        Me.DialogueButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label6"
        '
        'HexKeyPanel
        '
        Me.HexKeyPanel.BackColor = System.Drawing.SystemColors.Control
        Me.HexKeyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HexKeyPanel.Controls.Add(Me.BSubmit)
        Me.HexKeyPanel.Controls.Add(Me.BReset)
        Me.HexKeyPanel.Controls.Add(Me.TextBox1)
        Me.HexKeyPanel.Controls.Add(Me.BF)
        Me.HexKeyPanel.Controls.Add(Me.B4)
        Me.HexKeyPanel.Controls.Add(Me.B5)
        Me.HexKeyPanel.Controls.Add(Me.BE)
        Me.HexKeyPanel.Controls.Add(Me.B3)
        Me.HexKeyPanel.Controls.Add(Me.B6)
        Me.HexKeyPanel.Controls.Add(Me.BD)
        Me.HexKeyPanel.Controls.Add(Me.B2)
        Me.HexKeyPanel.Controls.Add(Me.B7)
        Me.HexKeyPanel.Controls.Add(Me.BC)
        Me.HexKeyPanel.Controls.Add(Me.B1)
        Me.HexKeyPanel.Controls.Add(Me.B8)
        Me.HexKeyPanel.Controls.Add(Me.BB)
        Me.HexKeyPanel.Controls.Add(Me.B0)
        Me.HexKeyPanel.Controls.Add(Me.B9)
        Me.HexKeyPanel.Controls.Add(Me.BA)
        Me.HexKeyPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HexKeyPanel.Location = New System.Drawing.Point(354, 17)
        Me.HexKeyPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HexKeyPanel.Name = "HexKeyPanel"
        Me.HexKeyPanel.Size = New System.Drawing.Size(114, 184)
        Me.HexKeyPanel.TabIndex = 6
        Me.HexKeyPanel.Visible = False
        '
        'BReset
        '
        Me.BReset.Location = New System.Drawing.Point(4, 154)
        Me.BReset.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BReset.Name = "BReset"
        Me.BReset.Size = New System.Drawing.Size(50, 23)
        Me.BReset.TabIndex = 21
        Me.BReset.Text = "R"
        Me.BReset.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(4, 4)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 38)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BF
        '
        Me.BF.Location = New System.Drawing.Point(85, 127)
        Me.BF.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BF.Name = "BF"
        Me.BF.Size = New System.Drawing.Size(23, 23)
        Me.BF.TabIndex = 19
        Me.BF.Text = "F"
        Me.BF.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(4, 73)
        Me.B4.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(23, 23)
        Me.B4.TabIndex = 8
        Me.B4.Text = "4"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(31, 73)
        Me.B5.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(23, 23)
        Me.B5.TabIndex = 9
        Me.B5.Text = "5"
        Me.B5.UseVisualStyleBackColor = True
        '
        'BE
        '
        Me.BE.Location = New System.Drawing.Point(58, 127)
        Me.BE.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BE.Name = "BE"
        Me.BE.Size = New System.Drawing.Size(23, 23)
        Me.BE.TabIndex = 18
        Me.BE.Text = "E"
        Me.BE.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(85, 46)
        Me.B3.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(23, 23)
        Me.B3.TabIndex = 8
        Me.B3.Text = "3"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(58, 73)
        Me.B6.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(23, 23)
        Me.B6.TabIndex = 10
        Me.B6.Text = "6"
        Me.B6.UseVisualStyleBackColor = True
        '
        'BD
        '
        Me.BD.Location = New System.Drawing.Point(31, 127)
        Me.BD.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BD.Name = "BD"
        Me.BD.Size = New System.Drawing.Size(23, 23)
        Me.BD.TabIndex = 17
        Me.BD.Text = "D"
        Me.BD.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(58, 46)
        Me.B2.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(23, 23)
        Me.B2.TabIndex = 8
        Me.B2.Text = "2"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Location = New System.Drawing.Point(85, 73)
        Me.B7.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(23, 23)
        Me.B7.TabIndex = 11
        Me.B7.Text = "7"
        Me.B7.UseVisualStyleBackColor = True
        '
        'BC
        '
        Me.BC.Location = New System.Drawing.Point(4, 127)
        Me.BC.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BC.Name = "BC"
        Me.BC.Size = New System.Drawing.Size(23, 23)
        Me.BC.TabIndex = 16
        Me.BC.Text = "C"
        Me.BC.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(31, 46)
        Me.B1.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(23, 23)
        Me.B1.TabIndex = 8
        Me.B1.Text = "1"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.Location = New System.Drawing.Point(4, 100)
        Me.B8.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(23, 23)
        Me.B8.TabIndex = 12
        Me.B8.Text = "8"
        Me.B8.UseVisualStyleBackColor = True
        '
        'BB
        '
        Me.BB.Location = New System.Drawing.Point(85, 100)
        Me.BB.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BB.Name = "BB"
        Me.BB.Size = New System.Drawing.Size(23, 23)
        Me.BB.TabIndex = 15
        Me.BB.Text = "B"
        Me.BB.UseVisualStyleBackColor = True
        '
        'B0
        '
        Me.B0.Location = New System.Drawing.Point(4, 46)
        Me.B0.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(23, 23)
        Me.B0.TabIndex = 7
        Me.B0.Text = "0"
        Me.B0.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.Location = New System.Drawing.Point(31, 100)
        Me.B9.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(23, 23)
        Me.B9.TabIndex = 13
        Me.B9.Text = "9"
        Me.B9.UseVisualStyleBackColor = True
        '
        'BA
        '
        Me.BA.Location = New System.Drawing.Point(58, 100)
        Me.BA.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.BA.Name = "BA"
        Me.BA.Size = New System.Drawing.Size(23, 23)
        Me.BA.TabIndex = 14
        Me.BA.Text = "A"
        Me.BA.UseVisualStyleBackColor = True
        '
        'KeyDownAssist
        '
        Me.KeyDownAssist.Location = New System.Drawing.Point(4, 447)
        Me.KeyDownAssist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KeyDownAssist.Name = "KeyDownAssist"
        Me.KeyDownAssist.Size = New System.Drawing.Size(168, 29)
        Me.KeyDownAssist.TabIndex = 7
        Me.KeyDownAssist.Text = "KeyDownAssist"
        Me.KeyDownAssist.UseVisualStyleBackColor = True
        '
        'BSubmit
        '
        Me.BSubmit.Location = New System.Drawing.Point(58, 154)
        Me.BSubmit.Name = "BSubmit"
        Me.BSubmit.Size = New System.Drawing.Size(50, 23)
        Me.BSubmit.TabIndex = 22
        Me.BSubmit.Text = "S"
        Me.BSubmit.UseVisualStyleBackColor = True
        '
        'NavButton2
        '
        Me.NavButton2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NavButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton2.EastNav = Me.NavButton2
        Me.NavButton2.FlatAppearance.BorderSize = 0
        Me.NavButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton2.Location = New System.Drawing.Point(231, 168)
        Me.NavButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.NavButton2.Name = "NavButton2"
        Me.NavButton2.NorthNav = Me.NavButton2
        Me.NavButton2.Size = New System.Drawing.Size(225, 30)
        Me.NavButton2.SouthNav = Me.NavButton4
        Me.NavButton2.TabIndex = 7
        Me.NavButton2.Text = "NavButton2"
        Me.NavButton2.UseVisualStyleBackColor = False
        Me.NavButton2.Visible = False
        Me.NavButton2.WestNav = Me.NavButton1
        '
        'NavButton4
        '
        Me.NavButton4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NavButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton4.EastNav = Me.NavButton4
        Me.NavButton4.FlatAppearance.BorderSize = 0
        Me.NavButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton4.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton4.Location = New System.Drawing.Point(231, 206)
        Me.NavButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.NavButton4.Name = "NavButton4"
        Me.NavButton4.NorthNav = Me.NavButton2
        Me.NavButton4.Size = New System.Drawing.Size(225, 30)
        Me.NavButton4.SouthNav = Me.NavButton4
        Me.NavButton4.TabIndex = 9
        Me.NavButton4.Text = "NavButton4"
        Me.NavButton4.UseVisualStyleBackColor = False
        Me.NavButton4.Visible = False
        Me.NavButton4.WestNav = Me.NavButton3
        '
        'NavButton3
        '
        Me.NavButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton3.EastNav = Me.NavButton4
        Me.NavButton3.FlatAppearance.BorderSize = 0
        Me.NavButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton3.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton3.Location = New System.Drawing.Point(4, 206)
        Me.NavButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.NavButton3.Name = "NavButton3"
        Me.NavButton3.NorthNav = Me.NavButton1
        Me.NavButton3.Size = New System.Drawing.Size(225, 30)
        Me.NavButton3.SouthNav = Me.NavButton3
        Me.NavButton3.TabIndex = 8
        Me.NavButton3.Text = "NavButton3"
        Me.NavButton3.UseVisualStyleBackColor = False
        Me.NavButton3.Visible = False
        Me.NavButton3.WestNav = Me.NavButton3
        '
        'NavButton1
        '
        Me.NavButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton1.EastNav = Me.NavButton2
        Me.NavButton1.FlatAppearance.BorderSize = 0
        Me.NavButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton1.Location = New System.Drawing.Point(4, 168)
        Me.NavButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.NavButton1.Name = "NavButton1"
        Me.NavButton1.NorthNav = Me.NavButton1
        Me.NavButton1.Size = New System.Drawing.Size(225, 30)
        Me.NavButton1.SouthNav = Me.NavButton3
        Me.NavButton1.TabIndex = 6
        Me.NavButton1.Text = "NavButton1"
        Me.NavButton1.UseVisualStyleBackColor = False
        Me.NavButton1.Visible = False
        Me.NavButton1.WestNav = Me.NavButton1
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.KeyDownAssist)
        Me.Controls.Add(Me.HexKeyPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Room"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.HexKeyPanel.ResumeLayout(False)
        Me.HexKeyPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents NavButton2 As NavButton
    Friend WithEvents NavButton4 As NavButton
    Friend WithEvents NavButton1 As NavButton
    Friend WithEvents NavButton3 As NavButton
    Friend WithEvents DialogueButton As Button
    Friend WithEvents HexKeyPanel As Panel
    Friend WithEvents BF As Button
    Friend WithEvents BE As Button
    Friend WithEvents BD As Button
    Friend WithEvents BC As Button
    Friend WithEvents BB As Button
    Friend WithEvents BA As Button
    Friend WithEvents B9 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents B0 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BReset As Button
    Friend WithEvents KeyDownAssist As Button
    Friend WithEvents BSubmit As Button
End Class
