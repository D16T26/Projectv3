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
            .Label1.Text = "Movement"
            .Label2.Text = "W - Move up"
            .Label3.Text = "A - Move West"
            .Label4.Text = "S - Move Down"
            .Label5.Text = "D - Move East"
            .Width = ProjectConstants.ContentWidth
            .Height = ProjectConstants.ContentHeight

            With .Panel1
                .Location = New Point(180, 240)
                .Height = 240
                .Width = 460
            End With
        End With
    End Sub

    Private Sub Room_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim r As Rectangle = New Rectangle(0, 0, ProjectConstants.ContentWidth, ProjectConstants.ContentHeight)
        e.Graphics.DrawImage(My.Resources.mal, r)
    End Sub
End Class
