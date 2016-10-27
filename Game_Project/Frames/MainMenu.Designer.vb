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
        Me.ExitButton = New Game_Project.NavButton()
        Me.StartButton = New Game_Project.NavButton()
        Me.EnterLevelCodeButton = New Game_Project.NavButton()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ExitButton.EastNav = Me.ExitButton
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.ExitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ExitButton.Location = New System.Drawing.Point(0, 419)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.NorthNav = Me.StartButton
        Me.ExitButton.Size = New System.Drawing.Size(640, 30)
        Me.ExitButton.SouthNav = Me.StartButton
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "    EXIT"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitButton.UseVisualStyleBackColor = False
        Me.ExitButton.WestNav = Me.ExitButton
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.StartButton.EastNav = Me.StartButton
        Me.StartButton.FlatAppearance.BorderSize = 0
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.StartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.StartButton.Location = New System.Drawing.Point(0, 359)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(0)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.NorthNav = Me.ExitButton
        Me.StartButton.Size = New System.Drawing.Size(640, 30)
        Me.StartButton.SouthNav = Me.ExitButton
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "    START"
        Me.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StartButton.UseVisualStyleBackColor = False
        Me.StartButton.WestNav = Me.StartButton
        '
        'EnterLevelCodeButton
        '
        Me.EnterLevelCodeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.EnterLevelCodeButton.EastNav = Me.EnterLevelCodeButton
        Me.EnterLevelCodeButton.Enabled = False
        Me.EnterLevelCodeButton.FlatAppearance.BorderSize = 0
        Me.EnterLevelCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnterLevelCodeButton.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.EnterLevelCodeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.EnterLevelCodeButton.Location = New System.Drawing.Point(0, 389)
        Me.EnterLevelCodeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.EnterLevelCodeButton.Name = "EnterLevelCodeButton"
        Me.EnterLevelCodeButton.NorthNav = Me.StartButton
        Me.EnterLevelCodeButton.Size = New System.Drawing.Size(640, 30)
        Me.EnterLevelCodeButton.SouthNav = Me.ExitButton
        Me.EnterLevelCodeButton.TabIndex = 2
        Me.EnterLevelCodeButton.Text = "    ENTER LEVEL CODE                                         (Not implemented)"
        Me.EnterLevelCodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EnterLevelCodeButton.UseVisualStyleBackColor = False
        Me.EnterLevelCodeButton.WestNav = Me.EnterLevelCodeButton
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EnterLevelCodeButton)
        Me.Controls.Add(Me.StartButton)
        Me.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartButton As NavButton
    Friend WithEvents EnterLevelCodeButton As NavButton
    Friend WithEvents ExitButton As NavButton
End Class
