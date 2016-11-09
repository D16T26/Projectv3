''' <summary>
''' This class was created simply to hold some constants.
''' I later repurposed it to also manage the various frame.
''' The intention was so that they can hold their state
''' when you move around but due to various circumstances there
''' are no siderooms after all and I saw no reason to add a mechanic
''' to backtrack when I culd guarantee there would be nothing of
''' interest where you have already been.
''' 
''' Perhaps we could havep pulled something of if the group was more experienced we
''' could have pulled something of.
''' </summary>
Public Class ProjectConstants
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1
    Public Const ContentWidth As Integer = 640
    Public Const ContentHeight As Integer = 480

    'Private introFrame As IntroFrame
    'Private Floor1RoomA As Room
    'Private Floor2RoomA As Room
    'Private Floor3RoomA As Room
    'Private Floor4RoomA As Room
    'Private Floor5RoomA As Room
    'Private Floor6RoomA As Room

    Public Sub New(Owner As Form1)
        Me.Owner = Owner
    End Sub

    Public Function getFloorAbove(oldRoom As Room)
        Select Case oldRoom.GetType
            Case GetType(F1RA)
                Return New F2RA(Me.Owner)
            Case GetType(F2RA)
                Return New F3RA(Me.Owner)
            Case GetType(F3RA)
                Return New F4RA(Me.Owner)
            Case GetType(F4RA)
                Return New F6RA(Me.Owner)
            Case Else
                ' Room.vb should never be instantiated. and this is the last room
                Return New F6RA(Me.Owner)
        End Select
    End Function

    Public Function fnMainMenu()
        Return New MainMenu(Me.Owner)
    End Function

    Public Function fnCredits()
        Return New Credits(Me.Owner)
    End Function

    Public Function fnIntroFrame()
        Return New IntroFrame(Me.Owner)
    End Function

    Public Function fnFloor1RoomA()
        Return New F1RA(Me.Owner)
    End Function
End Class
