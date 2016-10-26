Public Class IntroFrame
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1
    Private ReadOnly Property bColor As Color = ColorTranslator.FromHtml(My.Resources.BackColor)
    Private ReadOnly Property fColor As Color = ColorTranslator.FromHtml(My.Resources.ForeColor)

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
    End Sub

    Private Sub IntroFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Width = ProjectConstants.ContentWidth
            .Height = ProjectConstants.ContentHeight
            .BackColor = Me.bColor

            With .Label1
                .ForeColor = Me.fColor
                .Location = New Point(.Location.X + 20, .Location.Y)
                .Font = New Font(FontFamily.GenericMonospace, 10)
                .Text = Me.IntroText
            End With

            With .NavButton1
                .Location = New Point(0, ProjectConstants.ContentHeight - (.Height + 50))
                .Font = New Font(FontFamily.GenericMonospace, 10)
                .Width = ProjectConstants.ContentWidth
                .TextAlign = ContentAlignment.TopLeft
                .Text = " - Press ENTER/SPACE to continue"
                .Focus()
            End With
        End With
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
        Owner.StartGame()
    End Sub
End Class
