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


'Me.SetSize()
'Private Sub SetSize()
'    Me.Height = ProjectConstants.ContentHeight
'    Me.Width = ProjectConstants.ContentWidth
'End Sub

'Me.SetUpNavigation()
'''' <summary>
'''' Ensures that relative navigation between the navigation buttons
'''' are hooked up properly. well, if oyu want to be semantically correct.
'''' it sets it, as there is no way to set it elsewhere sensibly.
'''' 
'''' technically, it is supposed to be possible to do it in the designer,
'''' I have seen it. but I cant reproduce whatever it is that made the
'''' option show up, thus it is put here
'''' </summary>
'Private Sub SetUpNavigation()
'    Dim ButtonYOffset As Integer = 0
'    With Me.StartButton
'        .NorthNav = Me.ExitButton
'        .SouthNav = Me.ExitButton
'        .Location = New Point(0, .Location.Y + ButtonYOffset)
'        .Width = ProjectConstants.ContentWidth
'        .TextAlign = ContentAlignment.TopLeft
'        .Text = "    START"
'        .Focus()
'    End With

'    With Me.EnterLevelCodeButton
'        .NorthNav = Me.StartButton
'        .SouthNav = Me.ExitButton
'        .Location = New Point(0, .Location.Y + ButtonYOffset)
'        .Width = ProjectConstants.ContentWidth
'        .TextAlign = ContentAlignment.TopLeft
'        .Text = "    ENTER LEVEL CODE                                         (Not implemented)"
'        .Enabled = False
'    End With

'    With Me.ExitButton
'        .NorthNav = Me.StartButton
'        .SouthNav = Me.StartButton
'        .Location = New Point(0, .Location.Y + ButtonYOffset)
'        .Width = ProjectConstants.ContentWidth
'        .TextAlign = ContentAlignment.TopLeft
'        .Text = "    EXIT"
'    End With
'End Sub


