﻿''' <summary>
''' Room superclass. handles everything when it comes to component positioning,
''' as well as some rudimentary functions.
''' </summary>
Public Class Room
    Protected ReadOnly Property Owner As Form1
    Protected Property riddleWon As Boolean = False

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
        Me.ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
        Me.BackColor = Color.Transparent
        Me.HexKeyPanel.BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
        Me.KeyDownAssist.Size = New Size(0, 0)
    End Sub

    ''' <summary>
    ''' Writes to the keypad textbox, but limits it to 4 characters.
    ''' </summary>
    Private Sub HexKeyPadInput_Click(sender As Button, e As EventArgs) Handles _
        B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click,
        B8.Click, B9.Click, BA.Click, BB.Click, BC.Click, BD.Click, BE.Click, BF.Click

        If TextBox1.TextLength < 4 Then
            TextBox1.Text &= sender.Text
        End If
    End Sub

    ''' <summary>
    ''' Resets the he keypad
    ''' </summary>
    Private Sub HexKeyPadReset_Click(sender As Button, e As EventArgs) Handles BReset.Click
        TextBox1.Text = ""
    End Sub

    ''' <summary>
    ''' Ensures that the movement assist button always has focus when the keypad is up
    ''' </summary>
    Private Sub HexKeyPadInput_GotFocus(sender As Button, e As EventArgs) Handles _
        B0.GotFocus, B1.GotFocus, B2.GotFocus, B3.GotFocus,
        B4.GotFocus, B5.GotFocus, B6.GotFocus, B7.GotFocus,
        B8.GotFocus, B9.GotFocus, BA.GotFocus, BB.GotFocus,
        BC.GotFocus, BD.GotFocus, BE.GotFocus, BF.GotFocus,
        BReset.GotFocus

        KeyDownAssist.Select()
    End Sub

    ''' <summary>
    ''' Sets the background of the room.
    ''' </summary>
    Private Sub Room_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim r As Rectangle = New Rectangle(0, 0, ProjectConstants.ContentWidth, ProjectConstants.ContentHeight)
        e.Graphics.DrawImage(My.Resources.mal, r)
    End Sub

    ''' <summary>
    ''' Sets the dialogue button as focus when a new room is entered
    ''' </summary>
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DialogueButton.Focus()
        Me.InitiateHealthBar()
    End Sub

    ''' <summary>
    ''' Allows the player to move up
    ''' </summary>
    Private Sub Movement(sender As Button, e As KeyEventArgs) Handles KeyDownAssist.KeyDown
        Select Case e.KeyCode
            Case Keys.E
                If riddleWon Then
                    Owner.ChangeRoom(Me)
                End If
        End Select
    End Sub

    ''' <summary>
    ''' Reduces the players health.
    ''' and initiates a gameover if the health reaches 0
    ''' </summary>
    Protected Sub decrementHealthbar()
        Static hasFailedBefore As Boolean = False
        If Not hasFailedBefore Then
            Me.displayTextLabel.Text &= Environment.NewLine & "Ouch!"
            hasFailedBefore = True
        End If

        healthbar.Show()
        Owner.playerHealth -= 46
        Me.healthbar.Width = Owner.playerHealth
        Me.setHealthBarColor()

        If Me.healthbar.Width <= 0 Then
            Timer1.Enabled = False
            Owner.GameOver()
        End If
    End Sub

    Private Sub setHealthBarColor()
        If Me.healthbar.Width <= (0.2 * 460) Then
            Me.healthbar.BackColor = Color.Red
        ElseIf Me.healthbar.Enabled <= (0.8 * 460) Then
            Me.healthbar.BackColor = Color.Gold
        End If
    End Sub

    Friend Sub InitiateHealthBar()
        If Owner.playerHealth < 460 Then
            healthbar.Width = Owner.playerHealth
            Me.setHealthBarColor()
            Me.healthbar.Show()
        End If
    End Sub
End Class