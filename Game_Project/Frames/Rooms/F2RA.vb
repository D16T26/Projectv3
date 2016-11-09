''' <summary>
''' This is one of two relatively unique rooms in the tower.
''' the other one is slightly more unique, but who keeps count.
''' 
''' In this room our trusty hero meets his worst nightmare, three doggies.
''' He finds some bacon locked behind a glass window. what? Who you don't
''' randomly lock bacon behind glass windows?
''' 
''' Our hero needs to figure out hte code to open the glass window to get the
''' bacon to distract those pesky dogs.
''' 
''' Riddle:
'''     What is the hexadecimal value of: 1101 0101 0100 1110
'''     Answer: D54E
''' </summary>
Public Class F2RA
    Public ReadOnly Property author As String = "Ole Jørgen Valla Dønnem"

    Public Sub New(owner As Form1)
        MyBase.New(owner)
        InitializeComponent() 'without this, everything breaks
        Me.initialize()
    End Sub

    ''' <summary>
    ''' Initializes the data for the room. here it simply sets the displaytext to
    ''' the first part of the dialogue.
    ''' </summary>
    Private Sub initialize()
        displayTextLabel.Text =
            "Du stopper i toppen av trappen til andre etasje og ser" & Environment.NewLine &
            "ditt værste mareritt, tre rabide hunder. Dette må være" & Environment.NewLine &
            "Frumps berømte chihuahua trio og du er dødelig redd for" & Environment.NewLine &
            "hunder."
    End Sub

    ''' <summary>
    ''' This procedure is called when the dialogue button is clicked. due to dialogue here
    ''' naturally being split in two, it is done as such a way as to make the first click
    ''' simply continue the dialouge, while the second click will start the riddle.
    ''' </summary>
    Private Sub Button1_Click1(sender As Button, e As EventArgs) Handles DialogueButton.Click
        Static c As Boolean = False
        If Not c Then
            c = True
            displayTextLabel.Text =
                "Til høyre for deg ser du tre remser bacon" & Environment.NewLine &
                "låst bak ett glassvindu. Finn kombinasjonen," & Environment.NewLine &
                "få tak i baconet og distraher hundene lenge" & Environment.NewLine &
                "nok til å snike deg forbi dem"
        Else
            StartRiddle()
        End If
    End Sub

    ''' <summary>
    ''' Starts up the riddle by hiding the dialogue button, showing the hexkeypanel, as the riddle
    ''' in this particular room calls for a different type of interface than room 1 and 3 though 4.
    ''' display text is also set to the appropriate text for informing the user what buttons best
    ''' to click.
    ''' </summary>
    Private Sub StartRiddle()
        DialogueButton.Hide()
        HexKeyPanel.Show()
        displayTextLabel.Text =
            "Du ser det står gravert inn noen tall under" & Environment.NewLine &
            "glassvinduet, kan dette ha noe med koden for" & Environment.NewLine &
            "å åpne vinduet?" & Environment.NewLine & Environment.NewLine &
            "1101 0101 0100 1110"

        Me.Label6.Show()
        Me.Label7.Show()
        Me.Label8.Show()
        Me.Label9.Show()
        Me.Label10.Show()
    End Sub

    ''' <summary>
    ''' Is called when the submit button on the hexkeypanel is clicked (aptly named "S")
    ''' if the code on the display is correct. the panel is hidden, the riddle is set to won
    ''' and the display text is set to an appropriate congratulatory message.
    ''' 
    ''' otherwise, the user is thrown into the abyss known as popup messages.
    ''' </summary>
    Private Sub BSubmit_Click(sender As Object, e As EventArgs) Handles BSubmit.Click
        If TextBox1.Text = "D54E" Then
            riddleWon = True
            HexKeyPanel.Hide()
            displayTextLabel.Text =
                "Riktig kode!" & Environment.NewLine &
                "Du fikk tak i baconet, distrahert hundene" & Environment.NewLine &
                "og du kan nå gå videre til neste etasje.."

            Me.Label6.Hide()
            Me.Label7.Hide()
            Me.Label8.Hide()
            Me.Label9.Hide()
            Me.Label10.Hide()
        Else
            Me.decrementHealthbar()
        End If
    End Sub
End Class
