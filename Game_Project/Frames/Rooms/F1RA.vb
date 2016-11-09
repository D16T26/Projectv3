''' <summary>
''' Our hero has arrived at the tower. there is a doorguard however.
''' the guard requires a riddle to be answered before you can pass through.
''' 
''' Mr. Frump appears to have very lax security.
''' 
''' Riddle:
'''     Mr. Frump har fire døtre, hver datter har en bror.
'''     Hvor mange unger har Mr. Frump?
'''     Answers:
'''         Correct: 5
'''         Wrong: 9
'''         Wrong: 6
'''         Wrong: 4
''' </summary>
Public Class F1RA
    Public ReadOnly Property author As String = "Sondre Grøneng"

    ''' <summary>
    ''' Constructor for F1RA, it constructs.
    ''' most the meat happens in the constructor of the superclass, Room.
    ''' </summary>
    ''' <param name="Owner"></param>
    Public Sub New(Owner As Form1)
        MyBase.New(Owner)
        InitializeComponent() 'without this, everything breaks.
        Me.Initialize()
    End Sub

    ''' <summary>
    ''' Initialises local data for the room. initial dialogue text and setting
    ''' the answers to the buttons
    ''' </summary>
    Private Sub Initialize()
        Me.displayTextLabel.Text =
            “Du ser inngangen til tårnet men det står en dørvakt" & Environment.NewLine &
            "i veien, han krever du løser en gåte for å komme" & Environment.NewLine &
            "forbi.”

        Me.NavButton1.Text = 8
        Me.NavButton2.Text = 5
        Me.NavButton3.Text = 6
        Me.NavButton4.Text = 4
    End Sub

    ''' <summary>
    ''' This handles dialogue procession. In this particular room there is no extra
    ''' dialogue before the riddle so it simply initialises the riddle.
    ''' it used to check for whether or not the riddle had been completed.
    ''' the check was removed due to the fact that the button is hidden completely
    ''' once the riddle starts and never shows up again.
    ''' </summary>
    Private Sub DialogueButton_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        Me.StartRiddle()
    End Sub

    ''' <summary>
    ''' This procedure initialises the riddle itself by setting the display to the
    ''' the riddle and showing the navbuttons. navbutton1 is also set as focus so
    ''' the player do not have to use the mouse. the mouse is evil.
    ''' </summary>
    Private Sub StartRiddle()
        Me.DialogueButton.Hide()
        Me.displayTextLabel.Text =
                """Mr. Frump har fire døtre, hver datter har en bror." & Environment.NewLine &
                "Hvor mange unger har Mr. Frump?"""

        Me.NavButton1.Show()
        Me.NavButton2.Show()
        Me.NavButton3.Show()
        Me.NavButton4.Show()
        Me.NavButton1.Focus()
        Me.Label3.Show()
        Me.Label5.Show()
    End Sub

    ''' <summary>
    ''' This procedure is called when nay of the navbuttons holding the
    ''' wrong answer to the riddle is called. as of now it simply throws
    ''' up a popup message. though, to be fair, I dont think you could get
    ''' a more sinister punishment than a popup message
    ''' </summary>
    Private Sub WrongAnswer_Click(sender As NavButton, e As EventArgs) Handles _
            NavButton1.Click, NavButton3.Click, NavButton4.Click

        Dim text As String =
            "The epitome of punishments. Forcing a fellow human" & Environment.NewLine &
            "being to suffer the existence pop-up messages!!"
        Dim title As String = "L2Math mate"
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

        Me.Label3.Hide()
        Me.Label5.Hide()
        Me.displayTextLabel.Text = "Er vel bare å fortsette videre..."
    End Sub
End Class
