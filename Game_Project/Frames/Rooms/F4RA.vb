Public Class F4RA
    Public ReadOnly Property author As String = "Audun Flage"
    Public Sub New(owner As Form1)
        MyBase.New(owner)
        InitializeComponent()
        Me.Initialize()
    End Sub

    Private Sub Initialize()
        Me.Label6.Text = "Du er nå i fjerde etasje men her møter du også på en " & Environment.NewLine &
                         "dørvakt i veien, han krever du svarer på et spørsmål " & Environment.NewLine &
                         "å komme forbi."
    End Sub


    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            Me.StartRiddle()
        End If
    End Sub

    Private Sub StartRiddle()
        With Me
            .DialogueButton.Hide()
            .Label6.Text = """Hvis du ser rett på en regnbue, hvor er sola da?" & Environment.NewLine
            .DialogueButton.Hide()
            With .NavButton1
                .Show()
                .Text = "Foran deg"
                .Focus()
            End With
            With .NavButton2
                .Show()
                .Text = "Til høyre"
            End With
            With .NavButton3
                .Show()
                .Text = "Bak deg"
            End With
            With .NavButton4
                .Show()
                .Text = "Til venstre"
            End With
        End With
    End Sub

    Private Sub WrongAnswer_Click(sender As NavButton, e As EventArgs) Handles _
            NavButton1.Click, NavButton2.Click, NavButton4.Click
        Dim text As String =
            "The epitome of punishments. Forcing a fellow human" & Environment.NewLine &
            "being to suffer the existence pop-up messages!!"
        Dim title As String = "L2Math mate"
        Dim style As MsgBoxStyle = MsgBoxStyle.Critical

        MsgBox(text, style, title)
    End Sub

    Private Sub CorrectAnswer_Click(sender As NavButton, e As EventArgs) Handles NavButton3.Click
        With Me
            .riddleWon = True
            .NavButton1.Hide()
            .NavButton2.Hide()
            .NavButton3.Hide()
            .NavButton4.Hide()
            .Label6.Text = "Er vel bare å fortsette videre..."
        End With
    End Sub
End Class
