Public Class F1RA
    Public ReadOnly Property author As String = "Sondre Grøneng"

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
        With Me
            .DialogueButton.Hide()
            .Label6.Text = """Mr. Frump har fire døtre, hver datter har en bror." & Environment.NewLine &
                             "Hvor mange unger har Mr. Frump?"""
            With .NavButton1
                .Show()
                .Text = 8
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
End Class
