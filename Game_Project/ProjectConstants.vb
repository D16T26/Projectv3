Public Class ProjectConstants
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1
    Public Const ContentWidth As Integer = 640
    Public Const ContentHeight As Integer = 480

    Public ReadOnly Property mainMenu As MainMenu
    Public ReadOnly Property introFrame As IntroFrame
    Public ReadOnly Property Floor1RoomA As Room
    Public ReadOnly Property Floor2RoomA As Room
    Public ReadOnly Property Floor3RoomA As Room
    Public ReadOnly Property Floor4RoomA As Room
    Public ReadOnly Property Floor5RoomA As Room
    Public ReadOnly Property Floor6RoomA As Room

    Public Sub New(Owner As Form1)
        Me.Owner = Owner
        Me.mainMenu = New MainMenu(Me.Owner)
        Me.introFrame = New IntroFrame(Me.Owner)
        Me.Floor1RoomA = New F1RA(Me.Owner)
        Me.Floor2RoomA = New F2RA(Me.Owner)
        Me.Floor3RoomA = New F3RA(Me.Owner)
        Me.Floor4RoomA = New F4RA(Me.Owner)
        Me.Floor5RoomA = New F5RA(Me.Owner)
        Me.Floor6RoomA = New F6RA(Me.Owner)
    End Sub

    Friend Sub Dispose()
        Me.mainMenu.Dispose()
        Me.introFrame.Dispose()
        Me.Floor1RoomA.Dispose()
        Me.Floor2RoomA.Dispose()
        Me.Floor3RoomA.Dispose()
        Me.Floor4RoomA.Dispose()
        Me.Floor5RoomA.Dispose()
        Me.Floor6RoomA.Dispose()
    End Sub
End Class
