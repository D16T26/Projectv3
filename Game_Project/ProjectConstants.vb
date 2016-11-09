Public Class ProjectConstants
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1
    Public Const ContentWidth As Integer = 640
    Public Const ContentHeight As Integer = 480

    Public ReadOnly mainMenu As MainMenu
    Private introFrame As IntroFrame
    Private Floor1RoomA As Room
    Private Floor2RoomA As Room
    Private Floor3RoomA As Room
    Private Floor4RoomA As Room
    Private Floor5RoomA As Room
    Private Floor6RoomA As Room

    Public Sub New(Owner As Form1)
        Me.Owner = Owner
        Me.mainMenu = New MainMenu(Me.Owner)
        Me.initialize()
    End Sub

    Friend Sub reset()
        initialize()
    End Sub

    Private Sub initialize()
        Me.introFrame = New IntroFrame(Me.Owner)
        Me.Floor1RoomA = New F1RA(Me.Owner)
        Me.Floor2RoomA = New F2RA(Me.Owner)
        Me.Floor3RoomA = New F3RA(Me.Owner)
        Me.Floor4RoomA = New F4RA(Me.Owner)
        Me.Floor5RoomA = New F5RA(Me.Owner)
        Me.Floor6RoomA = New F6RA(Me.Owner)
    End Sub

    Public Function getFloorAbove(oldRoom As Room)
        Select Case oldRoom.GetType
            Case GetType(F1RA)
                Return Me.Floor2RoomA
            Case GetType(F2RA)
                Return Me.Floor3RoomA
            Case GetType(F3RA)
                Return Me.Floor4RoomA
            Case GetType(F4RA)
                Return Me.Floor5RoomA
            Case GetType(F5RA)
                Return Me.Floor6RoomA
            Case Else
                ' Room.vb should never be instantiated. and this is the last room
                Return Me.Floor6RoomA
        End Select
    End Function

    Public Function fnIntroFrame()
        Return Me.introFrame
    End Function

    Public Function fnFloor1RoomA()
        Return Me.Floor1RoomA
    End Function
End Class
