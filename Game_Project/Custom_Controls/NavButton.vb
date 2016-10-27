Public Class NavButton
    Inherits System.Windows.Forms.Button
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private Property Selected As Boolean = False
    Public Property NorthNav As NavButton
    Public Property WestNav As NavButton
    Public Property SouthNav As NavButton
    Public Property EastNav As NavButton
    'Private ReadOnly Property bColor As Color = ColorTranslator.FromHtml(My.Resources.BackColor)
    'Private ReadOnly Property fColor As Color = ColorTranslator.FromHtml(My.Resources.ForeColor)

    Public Sub New()
        Me.BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
        Me.ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
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
                Me.NorthNav.Focus()
            Case Keys.A
                Me.WestNav.Focus()
            Case Keys.S
                Me.SouthNav.Focus()
            Case Keys.D
                Me.EastNav.Focus()
        End Select
    End Sub

    Private Sub InvertColors()
        Dim TempColor = Me.ForeColor
        Me.ForeColor = Me.BackColor
        Me.BackColor = TempColor
    End Sub
End Class
