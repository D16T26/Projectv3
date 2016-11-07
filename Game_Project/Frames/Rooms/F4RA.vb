''' <summary>
''' In this room our hero meets another guard. the guard requires
''' the hero to answer a riddle to let him pass.
''' 
''' Riddle:
'''     Hvis du ser rett på en regnbue, hvor er sola da?
'''     Answers:
'''         Correct: Bak deg
'''         Wrong: Foran deg
'''         Wrong: Til høyre
'''         Wrong: Til venstre
''' </summary>
Public Class F4RA
    Public ReadOnly Property author As String = "Audun Flage"

    Public Sub New(owner As Form1)
        MyBase.New(owner)
        InitializeComponent()
        Me.Initialize()
    End Sub

    ''' <summary>
    ''' Initialises local data for the room. Dialogue text and setting
    ''' the answers to the buttons
    ''' </summary>
    Private Sub Initialize()
        Me.Label6.Text = "Du er nå i fjerde etasje men her møter du også på en " & Environment.NewLine &
                         "dørvakt i veien, han krever du svarer på et spørsmål " & Environment.NewLine &
                         "å komme forbi."

        Me.NavButton1.Text = "Foran deg"
        Me.NavButton2.Text = "Til høyre"
        Me.NavButton3.Text = "Bak deg"
        Me.NavButton4.Text = "Til venstre"
    End Sub

    ''' <summary>
    ''' This handles dialogue procession. In this particular room there is no extra
    ''' dialogue before the riddle so it simply initialises the riddle.
    ''' it used to check for whether or not the riddle had been completed.
    ''' the check was removed due to the fact that the button is hidden completely
    ''' once the riddle starts and never shows up again.
    ''' </summary>
    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        Me.StartRiddle()
    End Sub

    ''' <summary>
    ''' This procedure initialises the riddle itself by setting the display to the
    ''' the riddle and showing the navbuttons. navbutton1 is also set as focus so
    ''' the player do not have to use the mouse. the mouse is evil.
    ''' </summary>
    Private Sub StartRiddle()
        Me.DialogueButton.Hide()
        Me.Label6.Text = """Hvis du ser rett på en regnbue, hvor er sola da?" & Environment.NewLine

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
            NavButton1.Click, NavButton2.Click, NavButton4.Click
        Dim text As String =
            "The epitome of punishments. Forcing a fellow human" & Environment.NewLine &
            "being to suffer the existence pop-up messages!!"
        Dim title As String = "L2Refraction/Reflection/Dispersion mate"
        Dim style As MsgBoxStyle = MsgBoxStyle.Critical
        MsgBox(text, style, title)
    End Sub

    ''' <summary>
    ''' This procedure is called when the navbutton holding the correct answer to the
    ''' riddle is clicked. it hides the buttons in question, marks the riddle as complete
    ''' and changes the display text to a message indicating that the player can procede.
    ''' </summary>
    Private Sub CorrectAnswer_Click(sender As NavButton, e As EventArgs) Handles NavButton3.Click
        Me.riddleWon = True
        Me.NavButton1.Hide()
        Me.NavButton2.Hide()
        Me.NavButton3.Hide()
        Me.NavButton4.Hide()
        Me.Label6.Text = "Er vel bare å fortsette videre..."
    End Sub
End Class
