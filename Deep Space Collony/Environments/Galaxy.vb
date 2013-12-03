Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class Galaxy
    <NonSerialized()>
    Public WithEvents P As Screen 'The screen form for the game
    <NonSerialized()>
    Public WithEvents Music As New System.Media.SoundPlayer
    Public Sectors(26, 9) As sector 'A grid of sectors inside the Galaxy
    Public Tiles(26, 9) As galaxyTile 'A grid of galaxyTiles
    <NonSerialized()>
    Public WithEvents WorldTimer As New Timer With {
        .Enabled = True,
        .Interval = 10} 'The timer for the world to update on
    Public TickCount As Integer
    Public AddingShips As Boolean = False
    Public MakingWormhole As Boolean = False
    Public FleetToMove As fleet
    Public PirateCount As Integer
    Public Enum Produce 'The Resources used in game
        Resource
        Gas
        Science
    End Enum
    Public Enum Allegence 'The different allegences
        Neutral
        Friendly
        Enemy
    End Enum
    Public ProduceStores As New Dictionary(Of Produce, Integer) From {
        {Produce.Resource, 0},
        {Produce.Gas, 0},
        {Produce.Science, 0}
    } 'The stores of different produces

    Public Sub New(ByRef NParent As Screen)
        P = NParent
        RandomEvents.P = Me
        Music.Stream = My.Resources.Black_Vortex
        Music.PlayLooping()
        '-----Initialise the grid of sectors-----
        For X As Integer = 0 To 26
            For Y As Integer = 0 To 9
                Randomize()
                If Int(5 * Rnd()) = 0 Then 'If it should be filled
                    Sectors(X, Y) = New sector(Me, New Point(X, Y))
                End If
            Next
        Next
        '---------------------------------------------

        '-----Initialise the sector connections-----
        For Each i As sector In Sectors
            If i IsNot Nothing Then  'its not empty
                i.Make_Connetions()
            End If
        Next
        '-------------------------------------------

        '-----Initialize the starting sector-----
        Sectors(0, 0) = New sector(Me, New Point(0, 0))
        Sectors(0, 0).Make_Connetions()
        If Sectors(0, 0) IsNot Nothing Then
            For Each i As wormhole In Sectors(0, 0).Connections
                ReDim Sectors(i.Opening.X, i.Opening.Y).Connections(-1)
                Sectors(i.Opening.X, i.Opening.Y).Make_Connetions()
            Next
            Sectors(0, 0).Friendly = Allegence.Friendly  'Make it owned by the player
        Else
            P.GameGalaxy = New Galaxy(P)
            WorldTimer.Enabled = False
            Exit Sub
        End If
        For Each i As starSystem In Sectors(0, 0).Systems
            If i IsNot Nothing Then 'The starSystem is not empty
                i.Friendly = Allegence.Friendly 'Make it friendly
            End If
        Next
        Sectors(0, 0).Add_Fleet(New fleet(Sectors(0, 0), New playerCruiser, Allegence.Friendly)) 'Make a new fleet with a cruiser
        For i As Integer = 1 To 3
            Sectors(0, 0).Fleets(0).Add_Ship(New playerFrigate) 'Add three frigates to the fleet
        Next
        ProduceStores(Produce.Resource) = 400
        ProduceStores(Produce.Gas) = 400
        '----------------------------------------

        '-----Spawn Pirates-----
        Sectors(26, 9) = New sector(Me, New Point(26, 9))
        Sectors(26, 9).Make_Connetions()
        If Sectors(26, 9) IsNot Nothing Then
            For Each i As wormhole In Sectors(26, 9).Connections
                ReDim Sectors(i.Opening.X, i.Opening.Y).Connections(-1)
                Sectors(i.Opening.X, i.Opening.Y).Make_Connetions()
            Next
            Sectors(26, 9).Friendly = Allegence.Enemy
        Else
            P.GameGalaxy = New Galaxy(P)
            WorldTimer.Enabled = False
            Exit Sub
        End If
        For Each i As starSystem In Sectors(26, 9).Systems
            If i IsNot Nothing Then
                i.Friendly = Allegence.Enemy
            End If
        Next
        Dim Pirate As New fleet(Sectors(26, 9), New dreadnought, Allegence.Enemy)
        For i As Integer = 0 To 5
            Pirate.Add_Ship(New destroyer)
        Next
        Sectors(26, 9).Add_Fleet(Pirate)
        '-----------------------

        '-----Check for issolation------
        Sectors(0, 0).Viable() 'Start the chain at (0,0)
        For Each i As sector In Sectors
            If i IsNot Nothing Then
                If i.Checked = False Then 'It is impossible to get to
                    For Each e As starSystem In i.Systems
                        e.P = Nothing 'Remove all references
                    Next
                    i = Nothing 'Remove it
                End If
            End If
        Next
        If Sectors(26, 9) Is Nothing Then 'There's no pirates
            WorldTimer.Enabled = False
            P.GameGalaxy = New Galaxy(P)
            Exit Sub
        End If
        '-------------------------------

        '-----Initialise the grid of tiles-----
        For X As Integer = 0 To 26
            For Y As Integer = 0 To 9
                Tiles(X, Y) = New galaxyTile(Me, New Point(X, Y))
            Next
        Next
        For Each i As sector In Sectors
            If i IsNot Nothing Then
                i.Graphic = Tiles(i.Position.X, i.Position.Y)
                i.Graphic.Reference = i
                For Each e As starSystem In i.Systems
                    If e IsNot Nothing Then
                        e.Graphic = Tiles(e.Position.X, e.Position.Y)
                    End If
                Next
                i.Graphic.Update()
            End If
        Next
        '--------------------------------------

    End Sub

    Public Overridable Sub LoadGame(ByRef NParent As Screen)
        P = NParent
        P.Window.Controls.Clear()
        For Each i As galaxyTile In Tiles
            i.b = New btnTile(i)
            i.Update()
        Next
        WorldTimer = New Timer With {.Enabled = True, .Interval = 10}
    End Sub

    Private Sub Update() Handles WorldTimer.Tick
        '-----Spawn Pirates-----
        TickCount = TickCount + 1
        If Int(600 * Rnd()) = 0 And PirateCount < 7 Then 'There are less than 7 pirates
            Dim PirateSecs(-1) As sector
            Dim NeutralSecs(-1) As sector
            Dim ExitSec As sector

            For Each i As sector In Sectors
                If i IsNot Nothing Then
                    If i.Friendly = Allegence.Enemy Then
                        ReDim Preserve PirateSecs(PirateSecs.Length)
                        PirateSecs(UBound(PirateSecs)) = i
                    ElseIf i.Friendly = Allegence.Neutral Then
                        ReDim Preserve NeutralSecs(NeutralSecs.Length)
                        NeutralSecs(UBound(NeutralSecs)) = i
                    End If
                End If
            Next

            If Int(1000 * Rnd()) = 0 Then
                ExitSec = NeutralSecs(Int(NeutralSecs.Length * Rnd()))
                ExitSec.Add_Fleet(New PirateFleet(ExitSec, TickCount))
            Else
                ExitSec = PirateSecs(Int(PirateSecs.Length * Rnd()))
                ExitSec.Add_Fleet(New PirateFleet(ExitSec, TickCount))
            End If
        End If
        If Int(1000 * Rnd()) = 0 And PirateFleet.LongJumps < 7 Then
            PirateFleet.LongJumps = PirateFleet.LongJumps + 1
        End If
        '-----------------------

        '-----Update Sectors-----
        For Each i As sector In Sectors
            If i IsNot Nothing Then 'Make sure the sector isn't empty
                Dim GoOn As Boolean = False
                If i.Friendly = Allegence.Friendly Then 'its friendly 
                    GoOn = True
                ElseIf i.Fleets.Length <> 0 Then 'it has a fleet
                    GoOn = True
                End If
                If GoOn = True Then
                    i.Update()
                End If
                If Int(3240000 * Rnd()) = 0 Then
                    RandomEvents.Black_Hole(i)
                End If
            End If
        Next
        P.UpdateTick()
        '------------------------

        '-----Win or Lose-----
        Dim GameWinCheck As Boolean = True 'Theres no more Enemies
        Dim GameLoseCheck As Boolean = True 'Theres no more Friendlies
        For Each i As sector In Sectors
            If i IsNot Nothing Then
                If i.Friendly <> Allegence.Friendly Then
                    GameWinCheck = False 'Theres uncaptured areas
                ElseIf i.Friendly = Allegence.Friendly Then
                    GameLoseCheck = False 'Theres Friendlies
                End If
            End If
        Next
        '-----------------

        If GameWinCheck = True Or GameLoseCheck = True Then 'Gameover
            P.Pause_Click(Me, New EventArgs)
            Dim Temp As New GameOver(P)
            If GameLoseCheck = True Then 'The player lost
                Temp.ForeColor = Color.Red
                Temp.Text = "You Lost!"
            ElseIf GameWinCheck = True Then 'The player one
                Temp.ForeColor = Color.LawnGreen
                Temp.Text = "You Won!"
            End If
        End If
    End Sub

End Class
