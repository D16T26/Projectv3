<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NavButton2 = New Game_Project.NavButton()
        Me.NavButton1 = New Game_Project.NavButton()
        Me.NavButton3 = New Game_Project.NavButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NavButton2
        '
        Me.NavButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton2.FlatAppearance.BorderSize = 0
        Me.NavButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton2.Location = New System.Drawing.Point(4, 387)
        Me.NavButton2.Name = "NavButton2"
        Me.NavButton2.Size = New System.Drawing.Size(140, 30)
        Me.NavButton2.TabIndex = 2
        Me.NavButton2.Text = "NavButton2"
        Me.NavButton2.UseVisualStyleBackColor = False
        '
        'NavButton1
        '
        Me.NavButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton1.FlatAppearance.BorderSize = 0
        Me.NavButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton1.Location = New System.Drawing.Point(4, 351)
        Me.NavButton1.Name = "NavButton1"
        Me.NavButton1.Size = New System.Drawing.Size(140, 30)
        Me.NavButton1.TabIndex = 1
        Me.NavButton1.Text = "NavButton1"
        Me.NavButton1.UseVisualStyleBackColor = False
        '
        'NavButton3
        '
        Me.NavButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton3.FlatAppearance.BorderSize = 0
        Me.NavButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton3.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton3.Location = New System.Drawing.Point(4, 424)
        Me.NavButton3.Name = "NavButton3"
        Me.NavButton3.Size = New System.Drawing.Size(140, 30)
        Me.NavButton3.TabIndex = 3
        Me.NavButton3.Text = "NavButton3"
        Me.NavButton3.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NavButton3)
        Me.Controls.Add(Me.NavButton2)
        Me.Controls.Add(Me.NavButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Size = New System.Drawing.Size(640, 480)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NavButton1 As NavButton
    Friend WithEvents NavButton2 As NavButton
    Friend WithEvents NavButton3 As NavButton
End Class
