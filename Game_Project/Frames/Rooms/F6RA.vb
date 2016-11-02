Public Class F6RA
    Public Retning As String = "Venstre"
    Public teller As Integer = 0

    Public Sub New(Owner As Form1)
        MyBase.New(Owner)
        InitializeComponent()
        Timer1.Enabled = True
        Timer1.Interval = 700
        Timer2.Enabled = False
        Timer2.Interval = 50
        Timer3.Enabled = False
        Timer3.Interval = 3000
        Timer4.Enabled = False
        Timer4.Interval = 50

        Me.BackColor = Color.White
        pic1.Visible = False
        pic2.Visible = False
        pic3.Visible = False
        picFly.Visible = True
        picFly.Image = pic1.Image
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer3.Enabled = False
        Select Case Retning
            Case "Venstre"
                picFly.Left = Rnd() * (-500)
                picFly.Top = Rnd() * (-500)
                If picFly.Left <= 0 Then
                    Retning = "Høyre"
                End If
            Case "Høyre"
                picFly.Left = Rnd() * 500
                picFly.Top = Rnd() * 500
                If picFly.Left >= 300 Then
                    Retning = "Venstre"
                End If
        End Select
    End Sub

    Private Sub picFly_Click(sender As Object, e As EventArgs) Handles picFly.Click
        teller = teller + 1
        Timer1.Enabled = False
        Timer2.Enabled = True
        If teller = 3 Then
            Timer4.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picFly.Visible = False
        pic2.Visible = True
        Timer3.Enabled = True
        pic2.Top = 200 + Rnd() * 10
        pic2.Left = 300 + Rnd() * 10
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pic2.Visible = False
        picFly.Visible = True
        picFly.Image = pic1.Image
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        picFly.Image = pic3.Image
        'Tenkte spille av en seierslyd samtidig, men får ikke lyden til å fungere. 
        picFly.Top = 200 + Rnd() * 10
        picFly.Left = 300 + Rnd() * 10
    End Sub
End Class

