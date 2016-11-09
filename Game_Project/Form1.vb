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
    Friend Property playerHealth As Integer = 460

    Public Sub New()
        InitializeComponent() 'Without this, everything breaks.
        Me.projectConstants = New ProjectConstants(Me)
        Me.ContentPanel.Controls.Add(projectConstants.fnMainMenu)
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

    ''' <summary>
    ''' Changes the room to the room above.
    ''' decided to make it simple.
    ''' </summary>
    Friend Sub ChangeRoom(oldRoom As Room)
        With Me.ContentPanel.Controls
            .Clear()
            .Add(projectConstants.getFloorAbove(oldRoom))
        End With
    End Sub

    ''' <summary>
    ''' clears the contentpanel then refills it with the credits.
    ''' I think you just won the game
    ''' </summary>
    Public Sub ToCredits()
        Me.ContentPanel.Controls.Clear()
        Me.ContentPanel.Controls.Add(projectConstants.fnCredits)
    End Sub

    ''' <summary>
    ''' empties contentpanel to dereference anything there.
    ''' resets the gamestate by calling projectconstants.reset.
    ''' resets playerhealth
    ''' .oh, makes the mainmenu the active frame again.
    ''' </summary>
    Public Sub Restart()
        Me.ContentPanel.Controls.Clear()
        Me.projectConstants.reset()
        Me.ContentPanel.Controls.Add(projectConstants.fnMainMenu)
        Me.playerHealth = 460
    End Sub

    ''' <summary>
    ''' displays a game over message nad restarts the game.
    ''' </summary>
    Public Sub GameOver()
        MsgBox("GAME OVER")
        Me.Restart()
    End Sub

    ''' <summary>
    ''' Cleanly exits the program.
    ''' </summary>
    Friend Sub CleanExit()
        Application.Exit()
        End
    End Sub
End Class