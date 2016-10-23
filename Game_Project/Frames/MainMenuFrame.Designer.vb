<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuFrame
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.NavButton1 = New Game_Project.NavButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NavButton2 = New Game_Project.NavButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavButton1
        '
        Me.NavButton1.BackColor = System.Drawing.Color.Black
        Me.NavButton1.FlatAppearance.BorderSize = 0
        Me.NavButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton1.ForeColor = System.Drawing.Color.White
        Me.NavButton1.Location = New System.Drawing.Point(3, 385)
        Me.NavButton1.Name = "NavButton1"
        Me.NavButton1.Size = New System.Drawing.Size(140, 30)
        Me.NavButton1.TabIndex = 1
        Me.NavButton1.Text = "NavButton1"
        Me.NavButton1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NavButton2
        '
        Me.NavButton2.BackColor = System.Drawing.Color.Black
        Me.NavButton2.FlatAppearance.BorderSize = 0
        Me.NavButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton2.ForeColor = System.Drawing.Color.White
        Me.NavButton2.Location = New System.Drawing.Point(3, 422)
        Me.NavButton2.Name = "NavButton2"
        Me.NavButton2.Size = New System.Drawing.Size(140, 30)
        Me.NavButton2.TabIndex = 2
        Me.NavButton2.Text = "NavButton2"
        Me.NavButton2.UseVisualStyleBackColor = False
        '
        'MainMenuFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NavButton2)
        Me.Controls.Add(Me.NavButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenuFrame"
        Me.Size = New System.Drawing.Size(640, 480)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NavButton1 As NavButton
    Friend WithEvents NavButton2 As NavButton
End Class
