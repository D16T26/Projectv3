Public Class MainMenuFrame
    Private Sub MainMenuFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetSize()
        Me.PictureBox1.Image = My.Resources.dd_menu
    End Sub

    Private Sub SetSize()
        Me.Height = ProjectConstants.ContentHeight
        Me.Width = ProjectConstants.ContentWidth
        Me.PictureBox1.Height = ProjectConstants.ContentHeight
        Me.PictureBox1.Width = ProjectConstants.ContentWidth
    End Sub
End Class
