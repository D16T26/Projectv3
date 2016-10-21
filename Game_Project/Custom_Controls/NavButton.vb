Public Class NavButton
    Inherits System.Windows.Forms.Button
    Private Property Selected As Boolean = False

    Public Sub New()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        Me.Font = New Font(FontFamily.GenericMonospace, 10)
        Me.Size = New Size(140, 30)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
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

    Private Sub InvertColors()
        If Me.Selected Then
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
        Else
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
        End If
    End Sub
End Class
