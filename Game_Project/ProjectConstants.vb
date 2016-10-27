Public Class ProjectConstants
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1
    Public Const ContentWidth As Integer = 640
    Public Const ContentHeight As Integer = 480

    Public ReadOnly Property Floor1RoomA As Room
    Public ReadOnly Property Floor2RoomA As Room
    Public ReadOnly Property Floor3RoomA As Room
    Public ReadOnly Property Floor4RoomA As Room
    Public ReadOnly Property Floor5RoomA As Room
    Public ReadOnly Property Floor6RoomA As Room

    Public Sub New(Owner As Form1)
        Me.Owner = Owner
        Me.Floor1RoomA = New F1RA(Owner)
        Me.Floor2RoomA = Nothing
        Me.Floor3RoomA = Nothing
        Me.Floor4RoomA = Nothing
        Me.Floor5RoomA = Nothing
        Me.Floor6RoomA = Nothing
    End Sub
End Class
