Public Class GameOver
    Inherits Label

    Public Sub New()
        Font = New System.Drawing.Font("Modern No. 20", 71.99999, FontStyle.Bold)
        TextAlign = ContentAlignment.MiddleCenter
        Size = New Point(510, 100)
        Location = New Point(345, 300)
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        BackColor = Color.Goldenrod
        Screen.Controls.Add(Me)
        BringToFront()
    End Sub

End Class
