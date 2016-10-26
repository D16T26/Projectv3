Public Class ProjectConstants
    Public ReadOnly Property author As String = "Sondre Grøneng"
    Private ReadOnly Property Owner As Form1
    Public Const ContentWidth As Integer = 640
    Public Const ContentHeight As Integer = 480

    Public ReadOnly Property Room1 As Room

    Public Sub New(Owner As Form1)
        Me.Owner = Owner
    End Sub

End Class
