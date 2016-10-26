﻿Public Class Form1
    Public ReadOnly Property author As String = "Sondre Grøneng"
    'Mainly a guesstimate based on some testing in making it look right.
    'Due the form having borders, that are included in the Size property,
    'simply setting them to 640 and 480 does not work, as the actual
    'window would be too small. the width looked right when I added 16
    'to 640, thus I deduced this property.
    Private ReadOnly Property FormborderWidth As Integer = 8
    'Same as for FormBordereWidth, it looked right i added 39 to 480
    'so I subtracted 8 and made this property
    Private ReadOnly Property FormTopBarWidth As Integer = 31

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetSize()
        Me.Panel1.Controls.Add(New MainMenu(Me))
        'This button is only here to accept keyboard input
        Me.NavButton1.Size = New Size(0, 0)
    End Sub

    ''' <summary>
    ''' For some unknown reason, setting the size in the designer did not
    ''' yield the right result so I was forced to set the size again
    ''' programtically.
    ''' </summary>
    Private Sub SetSize()
        Me.Height = ProjectConstants.ContentHeight + FormTopBarWidth + FormborderWidth
        Me.Width = ProjectConstants.ContentWidth + 2 * FormborderWidth
        Me.Panel1.Height = ProjectConstants.ContentHeight
        Me.Panel1.Width = ProjectConstants.ContentWidth
    End Sub

    Friend Sub CleanExit()
        'TODO add code for disposal, later
        Application.Exit()
        End
    End Sub

    Friend Sub GoToIntro()
        With Me.Panel1.Controls
            .Clear()
            .Add(New IntroFrame(Me))
        End With
    End Sub

    Friend Sub StartGame()
        MsgBox("Bob")
    End Sub
End Class
