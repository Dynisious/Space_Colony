Public Class Screen
    Public GameGalaxy As Galaxy  'The Galaxy in the game
    Public MusicIsPlaying As Boolean = True

    Public Sub New()
        InitializeComponent()
        If MainMenu.Tutorial = False Then 'Its not a tutorial
            GameGalaxy = New Galaxy(Me)
        Else
            GameGalaxy = New tutorialGalaxy(Me)
        End If
        Visible = True
    End Sub

    Public Sub UpdateTick()
        '-----Display Stores-----
        lblStores.Text = "Resource: " +
            CStr(GameGalaxy.ProduceStores(Galaxy.Produce.Resource)) +
            ", Gas: " + CStr(GameGalaxy.ProduceStores(Galaxy.Produce.Gas)) +
            ", Science: " + CStr(GameGalaxy.ProduceStores(Galaxy.Produce.Science))
        '------------------------
    End Sub

    Private Sub btnZoomOut_Click(sender As System.Object, e As System.EventArgs) Handles btnZoomOut.Click
        GameGalaxy.Zoom_Out()
    End Sub

    Private Sub btnClosed_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnAddShips_Click(sender As System.Object, e As System.EventArgs) Handles btnAddShips.Click
        GameGalaxy.FleetToMove = Nothing
        GameGalaxy.ClosingWormhole = False
        GameGalaxy.AddingShips = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnClosingHoles.Click
        GameGalaxy.FleetToMove = Nothing
        GameGalaxy.ClosingWormhole = True
        GameGalaxy.AddingShips = False
    End Sub

    Public Sub Pause_Click(sender As System.Object, e As System.EventArgs) Handles Pause.Click
        Dim Temp As Boolean = False
        If GameGalaxy.WorldTimer.Enabled = False Then
            Temp = True
        End If
        For Each i As galaxyTile In GameGalaxy.Tiles
            i.b.Enabled = Temp
        Next
        GameGalaxy.WorldTimer.Enabled = Temp
        btnAddShips.Enabled = Temp
        btnZoomOut.Enabled = Temp
        btnClosingHoles.Enabled = Temp
        GameGalaxy.ClosingWormhole = Nothing
        GameGalaxy.AddingShips = Nothing
    End Sub

    Private Sub Music_Click(sender As System.Object, e As System.EventArgs) Handles Music.Click
        If MusicIsPlaying = True Then
            My.Computer.Audio.Stop()
            MusicIsPlaying = False
            Music.Text = "Play Music"
        Else
            My.Computer.Audio.Play(My.Resources.Black_Vortex, AudioPlayMode.BackgroundLoop)
            MusicIsPlaying = True
            Music.Text = "Stop Music"
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim Temp As New SaveLoad(SaveLoad.FileModes.Saving)
    End Sub
End Class
