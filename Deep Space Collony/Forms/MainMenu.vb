Public Class MainMenu
    Public Tutorial As Boolean = False

    Public Sub New()
        InitializeComponent()
        Visible = True
        My.Computer.Audio.Play(My.Resources.Sleep_and_Then, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Public Sub btnNewGame_Click(sender As System.Object, e As System.EventArgs) Handles btnNewGame.Click
        Screen.CreateControl()
        Close()
    End Sub

    Private Sub btnTutorial_Click(sender As System.Object, e As System.EventArgs) Handles btnTutorial.Click
        Tutorial = True
        Screen.CreateControl()
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