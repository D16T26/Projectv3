Public Class IntroFrame
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
        Me.Width = ProjectConstants.ContentWidth
        Me.Height = ProjectConstants.ContentHeight
        Me.BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
        Me.SetUpLabel1()
        Me.SetUpNavButton1()
    End Sub

    Private Sub SetUpLabel1()
        With Me.Label1
            .ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
            .Location = New Point(.Location.X + 20, .Location.Y)
            .Font = New Font(FontFamily.GenericMonospace, 10)
            .Text = Me.IntroText
        End With
    End Sub

    Private Sub SetUpNavButton1()
        With Me.NavButton1
            .Location = New Point(0, ProjectConstants.ContentHeight - (.Height + 50))
            .Font = New Font(FontFamily.GenericMonospace, 10)
            .Width = ProjectConstants.ContentWidth
            .TextAlign = ContentAlignment.TopLeft
            .Text = " - Press ENTER/SPACE to continue"
        End With
    End Sub

    Private Sub IntroFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.NavButton1.Focus()
    End Sub

    Private Function IntroText() As String
        'totally not a template
        Return "Lorem ipsum dolor sit amet, quaeque repudiandae qui cu. Quod oporteat vis" & Environment.NewLine &
               "et, est In novum platonem reformidans. Ea has esse consulatu. Ne eirmod" & Environment.NewLine &
               "sapientem vix. Pri eirmod complectitur reprehendunt in. Ius modo agam" & Environment.NewLine &
               "oporteat et. Sed te dolore facilis adolescens, vivendo appareat scriptorem" & Environment.NewLine &
               "at cum. Vix te mentitum adolescens. No vel zril ridens atomorum, an quo" & Environment.NewLine &
               "hinc dolore postea. No fabulas convenire adversarium his, est alienum" & Environment.NewLine &
               "singulis ad, in erat ornatus eos. Dolorum omnesque molestiae cu cum," & Environment.NewLine &
               "mandamus recteque id pri."
    End Function

    Private Sub NavButton1_Click(sender As Object, e As EventArgs) Handles NavButton1.Click
        Me.Owner.StartGame()
    End Sub
End Class
