Public Class MainMenu
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
    End Sub

    Private Sub NavButton1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Owner.GoToIntro()
    End Sub

    Private Sub NavButton3_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Owner.CleanExit()
    End Sub

    Private Sub Room_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim r As Rectangle = New Rectangle(0, 0, ProjectConstants.ContentWidth, ProjectConstants.ContentHeight)
        e.Graphics.DrawImage(My.Resources.dd_menu, r)
    End Sub
End Class