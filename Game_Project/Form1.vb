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

    Public Sub New()
        InitializeComponent() 'Without this, everything breaks.
        Me.projectConstants = New ProjectConstants(Me)
        Me.ContentPanel.Controls.Add(projectConstants.mainMenu)
    End Sub

    Friend Sub GoToIntro()
        With Me.ContentPanel.Controls
            .Clear()
            .Add(projectConstants.introFrame)
        End With
    End Sub

    Friend Sub StartGame()
        With Me.ContentPanel.Controls
            .Clear()
            .Add(projectConstants.Floor1RoomA)
        End With
    End Sub

    Friend Sub ChangeRoom(oldRoom As Room, direction As Direction)
        Dim newRoom As Room = Nothing

        If direction = Direction.Up Then
            Select Case oldRoom.GetType
                Case GetType(F1RA)
                    newRoom = projectConstants.Floor2RoomA
                Case GetType(F2RA)
                    newRoom = projectConstants.Floor3RoomA
                Case GetType(F3RA)
                    newRoom = projectConstants.Floor4RoomA
                Case GetType(F4RA)
                    newRoom = projectConstants.Floor5RoomA
                Case GetType(F5RA)
                    newRoom = projectConstants.Floor6RoomA
            End Select
        End If

        With Me.ContentPanel.Controls
            .Clear()
            .Add(newRoom)
        End With
    End Sub

    Private pName As String = ""
    Private playerNameAssigned As Boolean = False
    'Name of the player, shocking, I know.
    'You can "get" the name as many times as you want, but you can only assign it once
    Friend Property playerName As String
        Get
            Return pName
        End Get
        Set(value As String)
            If Not playerNameAssigned Then
                pName = value
                playerNameAssigned = True
            End If
        End Set
    End Property

    'Anything related to closing of game is handled here.

    Friend Sub CleanExit()
        Application.Exit()
        End
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.projectConstants.Dispose()
    End Sub
End Class