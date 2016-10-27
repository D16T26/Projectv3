Public Class Room
    Protected ReadOnly Property Owner As Form1

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
        Me.SetUpComponents()
    End Sub

    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SetUpComponents()
        With Me
            .BackColor = Color.Transparent
            .ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
            .Font = New Font(FontFamily.GenericMonospace, 10)
            .Width = ProjectConstants.ContentWidth
            .Height = ProjectConstants.ContentHeight

            .Label1.Text = "Movement"
            .Label2.Text = "I - Move up"
            .Label3.Text = "J - Move West"
            .Label4.Text = "K - Move Down"
            .Label5.Text = "L - Move East"

            With .Panel1
                .Location = New Point(180, 240)
                .Height = 240
                .Width = 460
            End With

            With .HexKeyPanel
                .ForeColor = Color.Black
                .Hide()
            End With

            With .NavButton1
                .SouthNav = NavButton3
                .EastNav = NavButton2
                .Hide()
            End With

            With .NavButton2
                .WestNav = NavButton1
                .SouthNav = NavButton4
                .Hide()
            End With

            With .NavButton3
                .NorthNav = NavButton1
                .EastNav = NavButton4
                .Hide()
            End With

            With .NavButton4
                .NorthNav = NavButton2
                .WestNav = NavButton3
                .Hide()
            End With
        End With
    End Sub

    Private Sub HexKeyPadInput_Click(sender As Button, e As EventArgs)

    End Sub

    Private Sub Room_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim r As Rectangle = New Rectangle(0, 0, ProjectConstants.ContentWidth, ProjectConstants.ContentHeight)
        e.Graphics.DrawImage(My.Resources.mal, r)
    End Sub
End Class
