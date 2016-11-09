''' <summary>
''' In This room our trusty hero is met with two thirsty guards that he/she
''' needs to get past. At least I think they are thirsty...
''' 
''' Riddle:
'''     Hva er hovedstaden i Tyrkia?
'''     Answers:
'''         Correct: Ankara
'''         Wrong: Istanbul
'''         Wrong: Alanya
'''         Wrong: Aleppo
''' </summary>
Public Class F5RA
    Public ReadOnly Property author As String = "Espen Skjelbreid"

    ''' <summary>
    ''' This is an array holding the dialogue sections for the
    ''' dialogue before the the riddle has been attempted.
    ''' </summary>
    Private ReadOnly preRiddleDialogue =
        {
            “Etter en ekstra lang trapp når du femte etasje." & Environment.NewLine &
            "Foran døren til Frump står to skumle vakter.",
            """Du kommer ikke forbi her uten avtale!""",
            "Du finner en brusautomat som gir gratis drikke," & Environment.NewLine &
            "men kun hvis du svarer på sikkerhetsspørsmålet!"
        }

    ''' <summary>
    ''' This is an array holding the dialogue sections for the dialogue
    ''' after the riddle has been completed.
    ''' </summary>
    Private ReadOnly postRiddleDialogue =
        {
            "Du går bort til de skumle vaktene og gir dem 2 iskalde" & Environment.NewLine &
            "coca-cola.",
            """Det var forfriskende. Men nå må vi på do!" & Environment.NewLine &
            "Gjør oss en tjeneste og ikke slipp noen forbi!""",
            "Vaktene forsvinner ned trappen og du kan nå gå videre!"
        }

    Public Sub New(owner As Form1)
        MyBase.New(owner)
        InitializeComponent() 'without this, everything breaks
        Me.Initialize()
    End Sub

    ''' <summary>
    ''' Initialises local data for the room. Initial dialogue text and setting
    ''' the answers to the buttons
    ''' </summary>
    Private Sub Initialize()
        Me.displayTextLabel.Text = preRiddleDialogue(0)

        Me.NavButton1.Text = "Istanbul"
        Me.NavButton2.Text = "Alanya"
        Me.NavButton3.Text = "Ankara"
        Me.NavButton4.Text = "Aleppo"
    End Sub

    ''' <summary>
    ''' This procedure is called when the dialogue button is clicked.
    ''' if the riddle is not won, it calles the handler for dialogue before
    ''' the riddle. otherwise it calls the handler for dialogue after the
    ''' riddle has been won.
    ''' </summary>
    Private Sub DialogueButton_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        If Not riddleWon Then
            PreRiddleDialogueHandler()
        Else
            PostRiddleDialogueHandler()
        End If
    End Sub

    ''' <summary>
    ''' Handler for the pre riddle dialogue. the integer is a counter
    ''' counting through the dialogue. the riddle is started once the
    ''' dialogue is done.
    ''' </summary>
    Private Sub PreRiddleDialogueHandler()
        Static prrdCounter As Integer = 1 'PReRiddleDialogueCounter
        If prrdCounter <= preRiddleDialogue.Length - 1 Then
            displayTextLabel.Text = preRiddleDialogue(prrdCounter)
            prrdCounter += 1
        Else
            Me.StartRiddle()
        End If
    End Sub

    ''' <summary>
    ''' Handler for the dialogue after the riddle has been won.
    ''' the integer is a counter, counting through the dialogue.
    ''' once the dialogue reaches its end, it terminates at the
    ''' last section.
    ''' </summary>
    Private Sub PostRiddleDialogueHandler()
        Static pordCounter As Integer = 1 'POstRiddleDialogueCounter
        If pordCounter <= postRiddleDialogue.Length - 1 Then
            displayTextLabel.Text = postRiddleDialogue(pordCounter)
            pordCounter += 1
            If pordCounter = 3 Then
                DialogueButton.Hide()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure initialises the riddle itself by adding the riddle to the
    ''' the displaytext and showing the navbuttons. navbutton1 is also set as focus so
    ''' the player do not have to use the mouse. the mouse is evil.
    ''' </summary>
    Private Sub StartRiddle()
        Me.DialogueButton.Hide()
        Me.displayTextLabel.Text &=
            Environment.NewLine &
            Environment.NewLine &
            """Hva heter hovedstaden i Tyrkia?"""

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
    ''' wrong answer to the riddle is called. Decrements health
    ''' </summary>
    Private Sub WrongAnswer_Click(sender As NavButton, e As EventArgs) Handles _
            NavButton1.Click, NavButton2.Click, NavButton4.Click
        Me.decrementHealthbar()
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

        Me.Label3.Hide()
        Me.Label5.Hide()
        Me.displayTextLabel.Text = postRiddleDialogue(0)
        Me.DialogueButton.Show()
        Me.DialogueButton.Focus()
    End Sub
End Class
