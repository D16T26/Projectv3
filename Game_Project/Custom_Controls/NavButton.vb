Public Class NavButton
    Inherits System.Windows.Forms.Button
    Public ReadOnly Property author As String = "Sondre Grøneng"
    ''' <summary>
    ''' the navbutton to be selected when pressing the W button
    ''' </summary>
    Public Property NorthNav As NavButton
    ''' <summary>
    ''' the navbutton to be selected when pressing the A button
    ''' </summary>
    Public Property WestNav As NavButton
    ''' <summary>
    ''' the navbutton to be selected when pressing the S button
    ''' </summary>
    Public Property SouthNav As NavButton
    ''' <summary>
    ''' the navbutton to be selected when pressing the D button
    ''' </summary>
    Public Property EastNav As NavButton

    Public Sub New()
        Me.BackColor = ColorTranslator.FromHtml(My.Resources.BackColor)
        Me.ForeColor = ColorTranslator.FromHtml(My.Resources.ForeColor)
        Me.Font = New Font(FontFamily.GenericMonospace, 10)
        Me.Size = New Size(140, 30)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0

        Me.NorthNav = Me
        Me.WestNav = Me
        Me.SouthNav = Me
        Me.EastNav = Me
    End Sub

    ''' <summary>
    ''' inverts colors when getting focus
    ''' </summary>
    Private Sub AtGotFocus(sender As Game_Project.NavButton, e As EventArgs) Handles Me.GotFocus
        Me.InvertColors()
    End Sub

    ''' <summary>
    ''' inverting coors when losing focus
    ''' </summary>
    Private Sub AtLostFocus(sender As Game_Project.NavButton, e As EventArgs) Handles Me.LostFocus
        Me.InvertColors()
    End Sub

    ''' <summary>
    ''' gives the button focus when the mouse enters.
    ''' 
    ''' I do not use hover since it takes too long for that event
    ''' to be raised as simply moving our mouse over the location, without stopping,
    ''' is not considered hover. which makes sense.
    ''' </summary>
    Private Sub AtMouseEnter(sender As Game_Project.NavButton, e As EventArgs) Handles Me.MouseEnter
        Me.Focus()
    End Sub

    ''' <summary>
    ''' Makes it so I can navigate between navbuttons using the WASD keys
    ''' It uses the values provided with the [Cardinal direction]Nav Property
    ''' </summary>
    Private Sub AtKeyDown(sender As Game_Project.NavButton, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                Me.NorthNav.Focus()
            Case Keys.A
                Me.WestNav.Focus()
            Case Keys.S
                Me.SouthNav.Focus()
            Case Keys.D
                Me.EastNav.Focus()
        End Select
    End Sub

    ''' <summary>
    ''' Swaps forecolor and backcolor
    ''' </summary>
    Private Sub InvertColors()
        Dim TempColor = Me.ForeColor
        Me.ForeColor = Me.BackColor
        Me.BackColor = TempColor
    End Sub
End Class
