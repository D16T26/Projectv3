﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DialogueButton = New System.Windows.Forms.Button()
        Me.displayTextLabel = New System.Windows.Forms.Label()
        Me.HexKeyPanel = New System.Windows.Forms.Panel()
        Me.BSubmit = New System.Windows.Forms.Button()
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
        Me.picFly = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.healthbar = New System.Windows.Forms.Panel()
        Me.NavButton2 = New Game_Project.NavButton()
        Me.NavButton4 = New Game_Project.NavButton()
        Me.NavButton3 = New Game_Project.NavButton()
        Me.NavButton1 = New Game_Project.NavButton()
        Me.Panel1.SuspendLayout()
        Me.HexKeyPanel.SuspendLayout()
        CType(Me.picFly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movement:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(32, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "E - Move up"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DialogueButton)
        Me.Panel1.Controls.Add(Me.NavButton2)
        Me.Panel1.Controls.Add(Me.NavButton4)
        Me.Panel1.Controls.Add(Me.NavButton1)
        Me.Panel1.Controls.Add(Me.displayTextLabel)
        Me.Panel1.Controls.Add(Me.NavButton3)
        Me.Panel1.Location = New System.Drawing.Point(180, 240)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 240)
        Me.Panel1.TabIndex = 5
        '
        'DialogueButton
        '
        Me.DialogueButton.Location = New System.Drawing.Point(407, 186)
        Me.DialogueButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DialogueButton.Name = "DialogueButton"
        Me.DialogueButton.Size = New System.Drawing.Size(30, 30)
        Me.DialogueButton.TabIndex = 6
        Me.DialogueButton.UseVisualStyleBackColor = True
        '
        'displayTextLabel
        '
        Me.displayTextLabel.AutoSize = True
        Me.displayTextLabel.Location = New System.Drawing.Point(12, 12)
        Me.displayTextLabel.Margin = New System.Windows.Forms.Padding(12)
        Me.displayTextLabel.Name = "displayTextLabel"
        Me.displayTextLabel.Size = New System.Drawing.Size(69, 20)
        Me.displayTextLabel.TabIndex = 0
        Me.displayTextLabel.Text = "Label6"
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
        Me.HexKeyPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HexKeyPanel.Name = "HexKeyPanel"
        Me.HexKeyPanel.Size = New System.Drawing.Size(114, 184)
        Me.HexKeyPanel.TabIndex = 6
        Me.HexKeyPanel.Visible = False
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
        Me.KeyDownAssist.Margin = New System.Windows.Forms.Padding(4)
        Me.KeyDownAssist.Name = "KeyDownAssist"
        Me.KeyDownAssist.Size = New System.Drawing.Size(172, 29)
        Me.KeyDownAssist.TabIndex = 7
        Me.KeyDownAssist.Text = "KeyDownAssist"
        Me.KeyDownAssist.UseVisualStyleBackColor = True
        '
        'picFly
        '
        Me.picFly.BackColor = System.Drawing.Color.Transparent
        Me.picFly.Location = New System.Drawing.Point(542, 126)
        Me.picFly.Name = "picFly"
        Me.picFly.Size = New System.Drawing.Size(75, 75)
        Me.picFly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFly.TabIndex = 11
        Me.picFly.TabStop = False
        Me.picFly.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'Timer4
        '
        Me.Timer4.Interval = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Multiple Choice:"
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "WASD - Select"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 156)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Key Panel:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Mouse - Select"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = """0""-""F"" - Type"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = """R"" - Reset"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = """S"" - Submit"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 266)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fighting Frump:"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Click on his face"
        Me.Label12.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Dialogue:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Space - Proceed"
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.Color.Transparent
        Me.pic2.Image = Global.Game_Project.My.Resources.Resources.pic2
        Me.pic2.Location = New System.Drawing.Point(187, 120)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(75, 75)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 9
        Me.pic2.TabStop = False
        Me.pic2.Visible = False
        '
        'healthbar
        '
        Me.healthbar.BackColor = System.Drawing.Color.Lime
        Me.healthbar.Location = New System.Drawing.Point(180, 0)
        Me.healthbar.Name = "healthbar"
        Me.healthbar.Size = New System.Drawing.Size(460, 20)
        Me.healthbar.TabIndex = 23
        Me.healthbar.Visible = False
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
        Me.Controls.Add(Me.healthbar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picFly)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.KeyDownAssist)
        Me.Controls.Add(Me.HexKeyPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Room"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.HexKeyPanel.ResumeLayout(False)
        Me.HexKeyPanel.PerformLayout()
        CType(Me.picFly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents displayTextLabel As Label
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
    Friend WithEvents picFly As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents healthbar As Panel
End Class
