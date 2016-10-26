Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        With Me
            With .NavButton1
                .Location = New Point(0, .Location.Y + 50)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = "    START"
                .NorthNav = Me.NavButton3
                .SouthNav = Me.NavButton2
            End With

            With .NavButton2
                .Location = New Point(0, .Location.Y + 50)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = "    ENTER LEVEL CODE                                         (Not implemented)"
                .NorthNav = Me.NavButton1
                .SouthNav = Me.NavButton3
            End With

            With .NavButton3
                .Location = New Point(0, .Location.Y + 50)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = "    EXIT"
                .NorthNav = Me.NavButton2
                .SouthNav = Me.NavButton1
            End With
        End With
    End Sub
End Class
