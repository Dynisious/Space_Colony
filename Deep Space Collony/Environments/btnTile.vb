Public Class btnTile
    Inherits Button
    Public P As galaxyTile

    Public Sub New(ByRef NParent As galaxyTile)
        P = NParent
        Size = New Point(40, 40)
        Location = New Point((40 * P.Position.X), (40 * P.Position.Y))
        FlatStyle = Windows.Forms.FlatStyle.Flat
        FlatAppearance.BorderSize = 1
        ForeColor = Color.LimeGreen
        P.P.P.Window.Controls.Add(Me)
    End Sub

    Private Sub Clicked(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        P.Clicked(e)
    End Sub

End Class
