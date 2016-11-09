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

    Public Sub New(Owner As Form1)
        Me.Owner = Owner
    End Sub

    ''' <summary>
    ''' A function that will select the next floor based on the floor that the
    ''' player is already on.
    ''' 
    ''' one reason to do it like this is that it makes it a lot easiere to
    ''' change the order, if I so desired.
    ''' </summary>
    ''' <param name="oldRoom">the Room the player is already in</param>
    ''' <returns>A new instance of the next room</returns>
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

    ''' <summary>
    ''' Returns a new instance of MainMenu
    ''' </summary>
    Public Function mainMenu()
        Return New MainMenu(Me.Owner)
    End Function

    ''' <summary>
    ''' Returns a new instance of Credits
    ''' </summary>
    Public Function credits()
        Return New Credits(Me.Owner)
    End Function

    ''' <summary>
    ''' Returns a new instance of IntroFrame
    ''' </summary>
    Public Function introFrame()
        Return New IntroFrame(Me.Owner)
    End Function

    ''' <summary>
    ''' Gets the first floor, since I do not have a zeroth floor
    ''' to jump from so I can use the getFloorAbove function.
    ''' </summary>
    ''' <returns>A new instance of F1RA</returns>
    Public Function floor1RoomA()
        Return New F1RA(Me.Owner)
    End Function
End Class
