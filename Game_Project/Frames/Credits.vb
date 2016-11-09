Public Class Credits
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
        Me.BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
        Me.ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)

        Me.Label1.Text =
            "Gratulerer, " & If(Owner.playerName = "", "", Owner.playerName & ", ") & "du klarte få Mr. Frump til rømme. Kelsey er fri."
    End Sub

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles Me.Load
        NavButton1.Focus()
    End Sub

    Private Sub NavButton1_Click(sender As Object, e As EventArgs) Handles NavButton1.Click
        Static alreadyClicked As Boolean = False
        If Not alreadyClicked Then
            Me.Label1.Location = New Point(Me.Label1.Location.X, 200)
            Me.Label1.Text =
                "Credits:" & Environment.NewLine &
                "    Audun Flage" & Environment.NewLine &
                "    Sondre Grøneng" & Environment.NewLine &
                "    Odd Egil Korsnes" & Environment.NewLine &
                "    Cathinka Pedersen" & Environment.NewLine &
                "    Espen Skjelbreid" & Environment.NewLine &
                "    Ole Jørgen Valla Dønnem"
            alreadyClicked = True
        Else
            Owner.Restart()
        End If
    End Sub
End Class
