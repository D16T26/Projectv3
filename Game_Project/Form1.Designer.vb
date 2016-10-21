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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NavButton1 = New Game_Project.NavButton()
        Me.NavButton2 = New Game_Project.NavButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NavButton2)
        Me.Panel1.Controls.Add(Me.NavButton1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.TabIndex = 0
        '
        'NavButton1
        '
        Me.NavButton1.BackColor = System.Drawing.Color.Black
        Me.NavButton1.FlatAppearance.BorderSize = 0
        Me.NavButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton1.ForeColor = System.Drawing.Color.White
        Me.NavButton1.Location = New System.Drawing.Point(226, 123)
        Me.NavButton1.Name = "NavButton1"
        Me.NavButton1.Size = New System.Drawing.Size(140, 30)
        Me.NavButton1.TabIndex = 0
        Me.NavButton1.Text = "NavButton1"
        Me.NavButton1.UseVisualStyleBackColor = False
        '
        'NavButton2
        '
        Me.NavButton2.BackColor = System.Drawing.Color.Black
        Me.NavButton2.FlatAppearance.BorderSize = 0
        Me.NavButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton2.ForeColor = System.Drawing.Color.White
        Me.NavButton2.Location = New System.Drawing.Point(226, 185)
        Me.NavButton2.Name = "NavButton2"
        Me.NavButton2.Size = New System.Drawing.Size(140, 30)
        Me.NavButton2.TabIndex = 1
        Me.NavButton2.Text = "NavButton2"
        Me.NavButton2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 481)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents NavButton2 As NavButton
    Friend WithEvents NavButton1 As NavButton
End Class
