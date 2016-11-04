Public Class F2RA

    Private Property riddleWon As Boolean = False
    Public Sub New(owner As Form1)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Label6.Text = "Du stopper i toppen av trappen til andre etasje og ser" & Environment.NewLine &
                        "ditt værste mareritt, tre rabide hunder. Dette må være" & Environment.NewLine &
                        "Frumps berømte chihuahua trio og du er dødelig redd for" & Environment.NewLine &
                        "hunder." & Environment.NewLine &
                        " " & Environment.NewLine &
                        "Men til høyre for deg ser du tre remser bacon" & Environment.NewLine &
                        "låst bak ett glassvindu. Finn kombinasjonen," & Environment.NewLine &
                        "få tak i baconet og distraher hundene lenge" & Environment.NewLine &
                        "nok til å snike deg forbi dem"

    End Sub

    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            StartRiddle()
        End If
    End Sub

    Private Sub StartRiddle()
        HexKeyPanel.Show()
        Label6.Text = "Du ser det står gravert inn noen tall under" & Environment.NewLine &
        "glassvinduet, kan dette ha noe med koden for" & Environment.NewLine &
        "å åpne vinduet?" & Environment.NewLine &
        " " & Environment.NewLine &
        "1101 0101 0100 1110"

    End Sub

    Private Sub BSubmit_Click(sender As Object, e As EventArgs) Handles BSubmit.Click
        ' Validere riktig svar på gåte

        If TextBox1.Text = "D54E" Then
            riddleWon = True
        Else
            Dim text As String = "Feil kode, prøv igjen!"
            Dim title As String = "Feil!"
            Dim style As MsgBoxStyle = MsgBoxStyle.Critical

            MsgBox(text, style, title)
        End If

        If riddleWon = True Then
            HexKeyPanel.Hide()
            Label6.Text = "Riktig kode!" & Environment.NewLine &
            "Du fikk tak i baconet, distrahert hundene" & Environment.NewLine &
            "og du kan nå gå videre til neste etasje.."
        End If
    End Sub

    Private Sub Movement(sender As Button, e As KeyEventArgs) Handles KeyDownAssist.KeyDown
        Select Case e.KeyCode
            Case Keys.I
                If riddleWon Then
                    Owner.ChangeRoom(Me, Direction.Up)
                End If
        End Select
    End Sub
End Class
