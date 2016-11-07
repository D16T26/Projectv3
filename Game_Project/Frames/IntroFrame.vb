Imports System.Text.RegularExpressions
''' <summary>
''' This is, as you can see, the frame handling the intro sequence.
''' it starts of with the queen introducing herself while askign the
''' player for his/her name. When the player has selected their name
''' she briefly introduces the task at hand and wishing the player
''' good luck. the player can then move on.
''' 
''' Sequence can also be quickly skipped by pressing enter twice.
''' Doing this will leave the player without having selected a name,
''' the horror, I know.
''' </summary>
Public Class IntroFrame
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1 'For communcating with form1

    Public Sub New(Owner As Form1)
        InitializeComponent() 'Without this, everything breaks.
        Me.Owner = Owner
        Me.BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
        Me.ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
        Me.Label1.Text =
            "Hei, jeg er dronning Chillary Klinton, jeg trenger din hjelp." & Environment.NewLine &
            "Hva heter du?”
    End Sub

    Private Sub IntroFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Focus()
    End Sub

    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click
        Me.Owner.StartGame()
    End Sub

    Private Sub NameTextBox_Keydown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Owner.playerName = Regex.Replace(TextBox1.Text, "\s{2,}", " ").Trim 'Strip superfluous whitespace from the user input. never trust users.
            TextBox1.Hide()
            StartGameButton.Show()
            StartGameButton.Select()
            Label1.Text =
                "Erkefienden min, Ronald Frump, har kidnappet min datter Kelsey" & Environment.NewLine &
                "og låst henne inn på toppen av Frump Tower. Du må redde henne" & Environment.NewLine &
                "for meg! Beveg deg gjennom rommene til toppen for å finne henne," & Environment.NewLine &
                "lykke til" & If(Owner.playerName = "", "", " ") & Owner.playerName & "!" 'Remove the space if the player left playername blank
            e.SuppressKeyPress = True 'Disables the ding when pressing enter in a text box.
        End If
    End Sub
End Class