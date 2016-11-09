Public Class F6RA
    Public ReadOnly Property author As String = "Cathinka Pedersen"
    Public synlig As Boolean = True
    Public teller As Integer = 0

    Public Sub New(Owner As Form1)
        MyBase.New(Owner)
        InitializeComponent()
        Me.initialize()
    End Sub

    Private Sub initialize()
        displayTextLabel.Text =
            "Du ser Mr. Frump stående forran deg." & Environment.NewLine &
            "..." & Environment.NewLine &
            "..." & Environment.NewLine &
            "TA HÅRET HANS!"
        Label11.Show()
        Label12.Show()
    End Sub

    ''' <summary>
    ''' Starts the fight against Mr. Frump.
    ''' 
    ''' </summary>
    Private Sub startFight()
        Timer1.Enabled = True

        Label11.Show()
        Label12.Show()

        picFly.Visible = True
        picFly.Image = My.Resources.pic1
    End Sub

    ''' <summary>
    ''' Called when the dialogue button is clicked.
    ''' there is only one section of dialogue here so
    ''' it just starts the fight directly, after hiding itself and
    ''' emptying the displaytext
    ''' </summary>
    Private Sub DialogueClick(sender As Button, e As EventArgs) Handles DialogueButton.Click
        DialogueButton.Hide()
        displayTextLabel.Text = ""
        startFight()
    End Sub

    ''' <summary>
    ''' Is called when you click on the flying head.
    ''' If the game is going on, you "Damage" Frump for 1/3
    ''' of his "Health".
    ''' If the game is won, you have clicked on him three times
    ''' when he is not stunned, you proceed to the credits.
    ''' </summary>
    Private Sub picFly_Click(sender As Object, e As EventArgs) Handles picFly.Click
        If riddleWon Then
            Owner.ToCredits()
        Else
            teller = teller + 1
            Timer1.Enabled = False
            Timer2.Enabled = True
            If teller = 3 Then
                Timer4.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' When this is active Frump randomly teleports around.
    ''' Half the time he will be invisible.
    ''' </summary>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not synlig Then
            Me.decrementHealthbar()
            Me.TeleportFrump()
            picFly.Show()
        Else
            picFly.Hide()
        End If
        synlig = Not synlig
    End Sub

    ''' <summary>
    ''' Changes the position of the pictuerbox holding the picture
    ''' of Mr. Frump to a random location within certian bonds.
    ''' </summary>
    Private Sub TeleportFrump()
        picFly.Left = 180 + Rnd() * (ProjectConstants.ContentWidth - 180 - picFly.Width)
        picFly.Top = 20 + Rnd() * (ProjectConstants.ContentHeight - 20 - picFly.Height)
    End Sub

    ''' <summary>
    ''' When you click on Mr. Frump, while he is not stunned, this timer starts
    ''' this is sorta when he IS stunned. Makees Frump.. vibrate.
    ''' </summary>
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picFly.Visible = False
        pic2.Visible = True
        Timer3.Enabled = True
        pic2.Top = 200 + Rnd() * 10
        pic2.Left = 300 + Rnd() * 10
    End Sub

    ''' <summary>
    ''' Three second timer that starts the same time as timer2
    ''' when it ticks, it hides the picturebox that is the one timer2 is shaking up
    ''' .it reshows picFly, the teleporting picturebox,, disables itself and timer 2
    ''' and re-enables timer1
    ''' </summary>
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pic2.Visible = False
        TeleportFrump()
        picFly.Visible = True
        Timer2.Enabled = False
        Timer1.Enabled = True
        Timer3.Enabled = False
    End Sub

    ''' <summary>
    ''' When the game is won, this timer starts and goes indefinitely. or until
    ''' you click on him again. though, that last part is my, Sondres, design,
    ''' since I had to go to credits somehow and I figured that yet another
    ''' timer is not needed for that.
    ''' </summary>
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        riddleWon = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        picFly.Image = My.Resources.pic3
        'Tenkte spille av en seierslyd samtidig, men får ikke lyden til å fungere. 
        picFly.Top = 200 + Rnd() * 10
        picFly.Left = 300 + Rnd() * 10
    End Sub
End Class

