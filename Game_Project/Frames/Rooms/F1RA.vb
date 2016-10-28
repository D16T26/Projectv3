Public Class F1RA
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private Property riddleWon As Boolean = False

    Public Sub New(Owner As Form1)
        MyBase.New(Owner)
        InitializeComponent()
        Me.Initialize()
    End Sub

    Private Sub Initialize()
        Me.Label6.Text = “Du ser inngangen til tårnet men det står en dørvakt" & Environment.NewLine &
                         "i veien, han krever du løser en gåte for å komme" & Environment.NewLine &
                         "forbi.”
    End Sub


    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            Me.StartRiddle()
        End If
    End Sub

    Private Sub StartRiddle()
        With Me
            .HexKeyPanel.Show()
            .Label6.Text = """Mr. Frump har fire døtre, hver datter har en bror." & Environment.NewLine &
                             "Hvor mange unger har Mr. Frump?"""
            With .NavButton1
                .Show()
                .Text = 8
                .Focus()
            End With
            With .NavButton2
                .Show()
                .Text = 5
            End With
            With .NavButton3
                .Show()
                .Text = 6
            End With
            With .NavButton4
                .Show()
                .Text = 4
            End With
        End With
    End Sub

    Private Sub WrongAnswer_Click(sender As NavButton, e As EventArgs) Handles _
            NavButton1.Click, NavButton3.Click, NavButton4.Click
        Dim text As String =
            "The epitome of punishments. Forcing a fellow human" & Environment.NewLine &
            "being to suffer the existence pop-up messages!!"
        Dim title As String = "L2Math mate"
        Dim style As MsgBoxStyle = MsgBoxStyle.Critical

        MsgBox(text, style, title)
    End Sub

    Private Sub CorrectAnswer_Click(sender As NavButton, e As EventArgs) Handles NavButton2.Click
        With Me
            .riddleWon = True
            .NavButton1.Hide()
            .NavButton2.Hide()
            .NavButton3.Hide()
            .NavButton4.Hide()
            .Label6.Text = "Er vel bare å fortsette videre..."
        End With
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
