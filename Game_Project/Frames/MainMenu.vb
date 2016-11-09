''' <summary>
''' This is the main menu. it has three buttons. one of which is disabled.
''' I mainly keep it there because it looks cool.
''' 
''' the when you click the start button, the game starts.
''' when you click the exitbutton, the game exits.
''' 
''' all of these procedures are simply called from the Owner property. or, basically,
''' the parent form.
''' </summary>
Public Class MainMenu
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1

    Public Sub New(Owner As Form1)
        InitializeComponent()
        Me.Owner = Owner
    End Sub

    Private Sub MainMenu_Load(owner As Object, e As EventArgs) Handles MyBase.Load
        StartButton.Focus()
    End Sub

    Private Sub NavButton1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Owner.GoToIntro()
    End Sub

    Private Sub NavButton3_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Owner.CleanExit()
    End Sub

    Private Sub Room_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim r As Rectangle = New Rectangle(0, 0, ProjectConstants.ContentWidth, ProjectConstants.ContentHeight)
        e.Graphics.DrawImage(My.Resources.dd_menu, r)
    End Sub
End Class