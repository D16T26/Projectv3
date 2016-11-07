Public Class F3RA
    Private Property riddleWon As Boolean = False

    Public Sub New(Owner As Form1)
        MyBase.New(Owner)
        InitializeComponent()
        Me.Initialize()
    End Sub

    Private Sub Initialize()
        Me.Label6.Text = "Midt i denne etasjen ser du Pike Mense," & Environment.NewLine &
        "bestekompisen til Frump, står halvnaken og ser på deg" & Environment.NewLine &
        "med lystfylte øyne. Han er tydeligvis veldig glad i " & Environment.NewLine &
        "menn, men du spiller ikke helt på det laget." & Environment.NewLine &
        "Han ber deg løse en gåte, om du ikke klarer den må du" & Environment.NewLine &
        "forbli i rommet og la han gjør hva han vil med deg " & Environment.NewLine &
        "i en time. Om du klarer den får du gå videre."
    End Sub


    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            Me.StartRiddle()
        End If
    End Sub

    Private Sub StartRiddle()
        With Me
            .DialogueButton.Hide()
            .Label6.Text = """What can you Catch, but don't throw?"""
            With .NavButton1
                .Show()
                .Text = "Gold"
                .Focus()
            End With
            With .NavButton2
                .Show()
                .Text = "Chlamydia"
            End With
            With .NavButton3
                .Show()
                .Text = "A ball with superglue"
            End With
            With .NavButton4
                .Show()
                .Text = "A falling angel"
            End With
        End With
    End Sub

    Private Sub WrongAnswer_Click(sender As NavButton, e As EventArgs) Handles _
            NavButton1.Click, NavButton3.Click, NavButton4.Click
        Dim text As String =
            "aiaiai. Den timen der kommer til å sette spor..."
        Dim title As String = "Straff"
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
            .Label6.Text = "Riktig! Du kan nå forsette videre."
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