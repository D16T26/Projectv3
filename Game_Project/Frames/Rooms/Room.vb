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
            .BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
            .ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
            .Font = New Font(FontFamily.GenericMonospace, 10)
            .Panel1.Height = ProjectConstants.ContentHeight
            .Label1.Text = "Movement"
            .Label2.Text = "W - Move up"
            .Label3.Text = "A - Move West"
            .Label4.Text = "S - Move Down"
            .Label5.Text = "D - Move East"

            .Width = ProjectConstants.ContentWidth
            .Height = ProjectConstants.ContentHeight
            With .PictureBox1
                .Location = New Point(0, 0)
                .Width = ProjectConstants.ContentWidth
                .Height = ProjectConstants.ContentHeight
                .Image = Nothing 'TODO get ahold of an actual image to put here
            End With
        End With
    End Sub
End Class
