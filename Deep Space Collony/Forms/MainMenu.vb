Public Class MainMenu
    Public Tutorial As Boolean = False
    Public NewScale As Decimal = 1

    Public Sub New()
        InitializeComponent()
        Visible = True
        My.Computer.Audio.Play(My.Resources.Sleep_and_Then, AudioPlayMode.BackgroundLoop)
        Dim HeightDif As Integer = Height - My.Computer.Screen.WorkingArea.Height
        Dim WidthDif As Integer = Width - My.Computer.Screen.WorkingArea.Width
        If WidthDif > 1 Or
            HeightDif > 1 Then
            If HeightDif > WidthDif Then
                NewScale = 1 - (1 / (Height / HeightDif))
            Else
                NewScale = 1 - (1 / (Width / WidthDif))
            End If
            Scale(New SizeF(NewScale, NewScale))
            Location = New Point(((My.Computer.Screen.WorkingArea.Width - Width) / 2),
                                 ((My.Computer.Screen.WorkingArea.Height - Height) / 2))
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Public Sub btnNewGame_Click(sender As System.Object, e As System.EventArgs) Handles btnNewGame.Click
        Screen.CreateControl()
        Screen.Scale(New SizeF(NewScale, NewScale))
        Close()
    End Sub

    Private Sub btnTutorial_Click(sender As System.Object, e As System.EventArgs) Handles btnTutorial.Click
        Tutorial = True
        Screen.CreateControl()
        Screen.Scale(New SizeF(NewScale, NewScale))
        tutorialWindow.CreateControl()
        My.Computer.Audio.Play(My.Resources.Black_Vortex, AudioPlayMode.BackgroundLoop)
        Close()
    End Sub

    Private Sub btnEncyclopedia_Click(sender As System.Object, e As System.EventArgs) Handles btnEncyclopedia.Click
        Encylopedia.CreateControl()
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Dim Temp As New SaveLoad(SaveLoad.FileModes.Loading)
    End Sub
End Class