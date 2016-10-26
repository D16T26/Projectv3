﻿Public Class NavButton
    Inherits System.Windows.Forms.Button
    Private Property Selected As Boolean = False
    Friend Property NorthNav As NavButton
    Friend Property WestNav As NavButton
    Friend Property SouthNav As NavButton
    Friend Property EastNav As NavButton
    Private ReadOnly Property bColor = ColorTranslator.FromHtml(My.Resources.BackColor)
    Private ReadOnly Property fColor = ColorTranslator.FromHtml(My.Resources.ForeColor)

    Public Sub New()
        Me.BackColor = Me.bColor
        Me.ForeColor = Me.fColor
        Me.Font = New Font(FontFamily.GenericMonospace, 10)
        Me.Size = New Size(140, 30)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0

        Me.NorthNav = Me
        Me.WestNav = Me
        Me.SouthNav = Me
        Me.EastNav = Me
    End Sub

    Private Sub AtGotFocus(sender As Game_Project.NavButton, e As EventArgs) Handles Me.GotFocus
        Me.Selected = True
        Me.Selecting()
    End Sub

    Private Sub AtLostFocus(sender As Game_Project.NavButton, e As EventArgs) Handles Me.LostFocus
        Me.Selected = False
        Me.InvertColors()
    End Sub

    Private Sub AtMouseEnter(sender As Game_Project.NavButton, e As EventArgs) Handles Me.MouseEnter
        Me.Focus()
    End Sub

    Private Sub Selecting()
        InvertColors()
    End Sub

    Private Sub AtKeyDown(sender As Game_Project.NavButton, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                NorthNav.Focus()
            Case Keys.A
                WestNav.Focus()
            Case Keys.S
                SouthNav.Focus()
            Case Keys.D
                EastNav.Focus()
        End Select
    End Sub

    Private Sub InvertColors()
        Dim TempColor = Me.ForeColor
        Me.ForeColor = Me.BackColor
        Me.BackColor = TempColor
    End Sub
End Class
