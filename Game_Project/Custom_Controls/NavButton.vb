Public Class NavButton
    Inherits System.Windows.Forms.Button

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'NavButton
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Size = New System.Drawing.Size(75, 30)
        Me.UseVisualStyleBackColor = False
        Me.ResumeLayout(False)

    End Sub
End Class
