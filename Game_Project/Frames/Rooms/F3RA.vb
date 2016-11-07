Public Class F3RA
    Public ReadOnly Property author As String = "Odd Egil Korsnes"
    Public Sub New(Owner As Form1)
        MyBase.New(Owner)
        InitializeComponent()
        Me.Initialize()
    End Sub

    Private Sub Initialize()
        Me.Label6.Text =
            "Midt i denne etasjen ser du Pike Mense," & Environment.NewLine &
            "bestekompisen til Frump, står halvnaken og ser på deg" & Environment.NewLine &
            "med lystfylte øyne. Han er tydeligvis veldig glad i " & Environment.NewLine &
            "menn, men du spiller ikke helt på det laget." & Environment.NewLine &
            "Han ber deg løse en gåte, om du ikke klarer den må du" & Environment.NewLine &
            "forbli i rommet og la han gjør hva han vil med deg " & Environment.NewLine &
            "i en time. Om du klarer den får du gå videre."

        Me.NavButton1.Text = "Gold"
        Me.NavButton2.Text = "Chlamydia"
        Me.NavButton3.Text = "A ball with superglue"
        Me.NavButton4.Text = "A falling angel"
    End Sub


    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            Me.StartRiddle()
        End If
    End Sub

    ''' <summary>
    ''' This procedure initialises the riddle itself by setting the display to the
    ''' the riddle and showing the navbuttons. navbutton1 is also set as focus so
    ''' the player do not have to use the mouse. the mouse is evil.
    ''' </summary>
    Private Sub StartRiddle()
        Me.DialogueButton.Hide()
        Me.Label6.Text = """What can you Catch, but don't throw?"""

        Me.NavButton1.Show()
        Me.NavButton2.Show()
        Me.NavButton3.Show()
        Me.NavButton4.Show()
        Me.NavButton1.Focus()
    End Sub

    ''' <summary>
    ''' This procedure is called when nay of the navbuttons holding the
    ''' wrong answer to the riddle is called. as of now it simply throws
    ''' up a popup message. though, to be fair, I dont think you could get
    ''' a more sinister punishment than a popup message
    ''' </summary>
    Private Sub WrongAnswer_Click(sender As NavButton, e As EventArgs) Handles _
            NavButton1.Click, NavButton3.Click, NavButton4.Click
        Dim text As String = "aiaiai. Den timen der kommer til å sette spor..."
        Dim title As String = "Straff"
        Dim style As MsgBoxStyle = MsgBoxStyle.Critical

        MsgBox(text, style, title)
    End Sub

    ''' <summary>
    ''' This procedure is called when the navbutton holding the correct answer to the
    ''' riddle is clicked. it hides the buttons in question, marks the riddle as complete
    ''' and changes the display text to a message indicating that the player can procede.
    ''' </summary>
    Private Sub CorrectAnswer_Click(sender As NavButton, e As EventArgs) Handles NavButton2.Click
        Me.riddleWon = True
        Me.NavButton1.Hide()
        Me.NavButton2.Hide()
        Me.NavButton3.Hide()
        Me.NavButton4.Hide()
        Me.Label6.Text = "Riktig! Du kan nå forsette videre."
    End Sub
End Class