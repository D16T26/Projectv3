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
        Me.ContentPanel.Controls.Add(projectConstants.Floor4RoomA) 'TODO, change back to INTRO
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

        If oldRoom.GetType Is GetType(F1RA) Then
            newRoom = projectConstants.Floor2RoomA
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

''Mainly a guesstimate based on some testing in making it look right.
''Due the form having borders, that are included in the Size property,
''simply setting them to 640 and 480 does not work, as the actual
''window would be too small. the width looked right when I added 16
''to 640, thus I deduced this property.
'Private ReadOnly Property FormborderWidth As Integer = 8
''Same as for FormBordereWidth, it looked right i added 39 to 480
''so I subtracted 8 and made this property
'Private ReadOnly Property FormTopBarWidth As Integer = 31

'Me.SetSize()
'''' <summary>
'''' For some unknown reason, setting the size in the designer did not
'''' yield the right result so I was forced to set the size again
'''' programtically.
'''' </summary>
'Private Sub SetSize()
'    Me.Height = ProjectConstants.ContentHeight + FormTopBarWidth + FormborderWidth
'    Me.Width = ProjectConstants.ContentWidth + 2 * FormborderWidth
'    Me.Panel1.Height = ProjectConstants.ContentHeight
'    Me.Panel1.Width = ProjectConstants.ContentWidth
'End Sub