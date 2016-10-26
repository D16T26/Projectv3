Public Class MainMenu
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
        Me.SetSize()
        Me.SetUpNavigation()
        Me.PictureBox1.Image = My.Resources.dd_menu
    End Sub

    Private Sub SetSize()
        With Me
            .Height = ProjectConstants.ContentHeight
            .Width = ProjectConstants.ContentWidth
            With .PictureBox1
                .Height = ProjectConstants.ContentHeight
                .Width = ProjectConstants.ContentWidth
            End With
        End With
    End Sub

    Private Sub SetUpNavigation()
        Dim ButtonYOffset As Integer = 50
        With Me
            With .NavButton1
                .Location = New Point(0, .Location.Y + ButtonYOffset)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = "    START"
                .NorthNav = Me.NavButton3
                .SouthNav = Me.NavButton3
                .Focus()
            End With

            With .NavButton2
                .Location = New Point(0, .Location.Y + ButtonYOffset)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = "    ENTER LEVEL CODE                                         (Not implemented)"
                .NorthNav = Me.NavButton1
                .SouthNav = Me.NavButton3
                .Enabled = False
            End With

            With .NavButton3
                .Location = New Point(0, .Location.Y + ButtonYOffset)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = "    EXIT"
                .NorthNav = Me.NavButton1
                .SouthNav = Me.NavButton1
            End With
        End With
    End Sub

    Private Sub NavButton1_Click(sender As Object, e As EventArgs) Handles NavButton1.Click
        Owner.GoToIntro()
    End Sub

    Private Sub NavButton3_Click(sender As Object, e As EventArgs) Handles NavButton3.Click
        Owner.CleanExit()
    End Sub
End Class
