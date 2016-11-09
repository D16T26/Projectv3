Imports System.ComponentModel
''' <summary>
''' The actual window holding the game. acts as a medium between different frames
''' as well. works like the main controller in a way. Even though most actions are
''' still handled in their individual frames. you move between them here.
''' </summary>
Public Class Form1
    Public ReadOnly Property author As String = "Sondre Grøneng"
    ''' <summary>
    ''' Main model of the game. holds things like all the rooms.
    ''' at the time of writing, the rooms are stored in individual
    ''' readonlies. If they are not. I forgot to edit this comment.
    ''' </summary>
    Friend ReadOnly Property projectConstants As ProjectConstants
    ''' <summary>
    ''' Name of the player as entered, by the player, during the intro.
    ''' </summary>
    Friend Property playerName As String = ""

    Public Sub New()
        InitializeComponent() 'Without this, everything breaks.
        Me.projectConstants = New ProjectConstants(Me)
        Me.ContentPanel.Controls.Add(projectConstants.mainMenu)
    End Sub

    ''' <summary>
    ''' Makes the intro frame the active frame.
    ''' </summary>
    Friend Sub GoToIntro()
        With Me.ContentPanel.Controls
            .Clear()
            .Add(projectConstants.fnIntroFrame)
        End With
    End Sub

    ''' <summary>
    ''' Starts the game by making floor 1 the active frame.
    ''' while one can argue that the gmae starts during the intro....
    ''' it does not.
    ''' </summary>
    Friend Sub StartGame()
        With Me.ContentPanel.Controls
            .Clear()
            .Add(projectConstants.fnFloor1RoomA)
        End With
    End Sub

    Friend Sub ChangeRoom(oldRoom As Room)
        With Me.ContentPanel.Controls
            .Clear()
            .Add(projectConstants.getFloorAbove(oldRoom))
        End With
    End Sub

    ''' <summary>
    ''' Cleanly exits the program.
    ''' </summary>
    Friend Sub CleanExit()
        Application.Exit()
        End
    End Sub
End Class