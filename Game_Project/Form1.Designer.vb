﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NavButton1 = New Game_Project.NavButton()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.TabIndex = 0
        '
        'NavButton1
        '
        Me.NavButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.NavButton1.FlatAppearance.BorderSize = 0
        Me.NavButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NavButton1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.NavButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.NavButton1.Location = New System.Drawing.Point(13, 439)
        Me.NavButton1.Name = "NavButton1"
        Me.NavButton1.Size = New System.Drawing.Size(140, 30)
        Me.NavButton1.TabIndex = 1
        Me.NavButton1.Text = "NavButton1"
        Me.NavButton1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 481)
        Me.Controls.Add(Me.NavButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Dungeons, and a Dragon "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents NavButton1 As NavButton
End Class
