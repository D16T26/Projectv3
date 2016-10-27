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
        Me.ContentPanel.Controls.Add(projectConstants.Floor1RoomA) 'TODO, change back to INTRO
    End Sub

    ''' <summary>
    ''' IntroFrame is not a subclass of Room, thus I cant use changeroom to hax
    ''' this one, shame.
    ''' </summary>
    Friend Sub GoToIntro()
        With Me.ContentPanel.Controls
            .Clear()
            .Add(New IntroFrame(Me))
        End With
    End Sub

    Friend Sub StartGame()
        Me.ChangeRoom(projectConstants.Floor1RoomA)
    End Sub

    ''' <summary>
    ''' Changes the currently displayed room. the previous room is
    ''' is simply cleared from the contentPanel. it is sitll stored in
    ''' projectConstants... Which I will need a better name for now that
    ''' it does more...
    ''' 
    ''' point is. it is stored there, so the state is saved.
    ''' another option in this area would be to store the state some other way
    ''' and dispose them everytime, but with a program as small as this. I am
    ''' not entirely sure that it would be worth the effort.
    ''' </summary>
    ''' <param name="newRoom">The new room that will be shown.</param>
    Friend Sub ChangeRoom(newRoom As Room)
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