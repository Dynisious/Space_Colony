Public Class Screen
    Public GameGalaxy As Galaxy  'The Galaxy in the game
    Public Tutorial As Boolean
    Public MusicIsPlaying As Boolean = True
    Public NewScale As Decimal = 1

    Public Sub New(ByVal NTutorial As Boolean)
        InitializeComponent()
        Tutorial = NTutorial
        If Tutorial = False Then 'Its not a tutorial
            GameGalaxy = New Galaxy(Me)
        Else
            GameGalaxy = New tutorialGalaxy(Me)
        End If
        Visible = True
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

    Public Sub UpdateTick()
        '-----Display Stores-----
        lblStores.Text = "Resource: " +
            CStr(GameGalaxy.ProduceStores(Galaxy.Produce.Resource)) +
            ", Gas: " + CStr(GameGalaxy.ProduceStores(Galaxy.Produce.Gas)) +
            ", Science: " + CStr(GameGalaxy.ProduceStores(Galaxy.Produce.Science))
        '------------------------
    End Sub

    Private Sub btnClosed_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnAddShips_Click(sender As System.Object, e As System.EventArgs) Handles btnAddShips.Click
        GameGalaxy.FleetToMove = Nothing
        GameGalaxy.MakingWormhole = False
        GameGalaxy.AddingShips = True
    End Sub

    Private Sub btnClosingHoles_Click(sender As System.Object, e As System.EventArgs) Handles btnClosingHoles.Click
        GameGalaxy.FleetToMove = Nothing
        GameGalaxy.MakingWormhole = True
        GameGalaxy.AddingShips = False
    End Sub

    Public Sub Pause_Click(sender As System.Object, e As System.EventArgs) Handles Pause.Click
        Dim Temp As Boolean = False
        If GameGalaxy.WorldTimer.Enabled = False Then
            Temp = True
        End If
        For Each i As galaxyTile In GameGalaxy.Tiles
            If i IsNot Nothing Then
                i.b.Enabled = Temp
            End If
        Next
        GameGalaxy.WorldTimer.Enabled = Temp
        btnAddShips.Enabled = Temp
        btnClosingHoles.Enabled = Temp
        GameGalaxy.MakingWormhole = Nothing
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
        Dim Temp As New SaveLoad(SaveLoad.FileModes.Saving, Me)
    End Sub
End Class
