Public Class F5RA
    Public ReadOnly Property author As String = "Espen Skjelbreid"
    Private Property counter As Integer = 0

    Public Sub New(owner As Form1)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        Me.Initialize()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Initialize()
        Me.Label6.Text = “Etter en ekstra lang trapp når du femte etasje." & Environment.NewLine &
                         "Foran døren til Frump står to skumle vakter."


    End Sub

    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            Select Case counter
                Case 0
                    Label6.Text = """Du kommer ikke forbi her uten avtale!"""
                Case 1
                    Label6.Text = "Bak deg ser du 2 dører som leder til hvert sitt rom..." & Environment.NewLine &
                         "Gå til venstre eller høyre."
                Case 2
                    Me.StartRiddle()
            End Select
            counter += 1
        End If
    End Sub

    Private Sub StartRiddle()
        With Me
            .DialogueButton.Hide()
            .Label6.Text = "Du finner en brusautomat som gir gratis drikke," & Environment.NewLine &
                             "men kun hvis du svarer på sikkerhetsspørsmålet!" & Environment.NewLine &
                             """Hva heter hovedstaden i Tyrkia?"""
            With .NavButton1
                .Show()
                .Text = "Istanbul"
                .Focus()
            End With
            With .NavButton2
                .Show()
                .Text = "Alanya"
            End With
            With .NavButton3
                .Show()
                .Text = "Ankara"
            End With
            With .NavButton4
                .Show()
                .Text = "Aleppo"
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
            .Label6.Text = "Du går bort til de skumle vaktene og gir dem 2 iskalde" & Environment.NewLine &
                           "coca-cola." & """Det var forfriskende. Men nå må vi på do!" & Environment.NewLine &
                           "Gjør oss en tjeneste og ikke slipp noen forbi!""" & Environment.NewLine &
                           "Vaktene forsvinner ned trappen og du kan nå gå videre!"
        End With
    End Sub
End Class
