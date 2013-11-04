Public Class ResearchingUpgrades
    Private Btns() As btnResearch

    Public Sub New()
        InitializeComponent()

        For X As Integer = 0 To 4
            For Y As Integer = 0 To 5
                ReDim Preserve Btns(X + (Y * 5))
                Btns(X + (Y * 5)) = New btnResearch(X, Y)
            Next
        Next
    End Sub

    Private Class btnResearch
        Inherits Button
        Private MyUpgrade As upgradeBase

        Public Sub New(ByVal X As Integer, ByVal Y As Integer)
            MyUpgrade = upgradeBase.ListOfUpgrades(X + (Y * 5))
            Location = New Point((80 * X) + 14, (40 * Y) + 10)
            Size = New Point(80, 40)
        End Sub

        Private Sub Clicked(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            MyUpgrade.Upgrade()
        End Sub
    End Class

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Screen.Enabled = True
        Screen.Pause_Click(Me, New EventArgs)
        Screen.BringToFront()
        Close()
    End Sub
End Class