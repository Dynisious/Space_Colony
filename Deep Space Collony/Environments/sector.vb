Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class sector
    Inherits BaseSpace
    Public WithEvents P As Galaxy 'The universe of the game
    Public Position As Point 'The sectors position in the universe
    Public Systems(26, 9) As starSystem 'A grid of starSystems inside the sector
    Public Fleets(-1) As fleet 'The fleets inside the sector
    Public Connections(-1) As wormhole 'The sectors that you can move to from here
    Public Battle As Combat
    Public Highlighted As Boolean = False
    Public Checked As Boolean = False
    Public Info As String

    Public Sub New(ByRef NParent As Galaxy, ByVal NPosition As Point)
        P = NParent
        Position = NPosition
        Friendly = Galaxy.Allegence.Neutral
        Randomize()
        '-----Initialiaze the Grid of starSystems-----
        For X As Integer = 0 To 26
            For Y As Integer = 0 To 9
                Randomize()
                If Int(43 * Rnd()) = 0 Then 'Shouldn't it be Empty
                    Systems(X, Y) = New starSystem(Me, New Point(X, Y))
                End If
            Next
        Next
        '---------------------------------------------

        '-----Check for issolation-----
        If Connections.Length < 2 Then
            P.Sectors(Position.X, Position.Y) = Nothing
        End If
        '------------------------------
    End Sub

    Public Sub Make_Connetions()
        Dim XStart As Integer 'The starting x-int of the radius
        Dim XEnd As Integer 'The ending point of the x axis
        Dim YStart As Integer 'The starting y-int of the radius
        Dim YEnd As Integer 'The ending point of the y axis
        '-----Mark the starting point-----
        For i As Integer = 0 To 2
            If Position.X - i >= 0 Then
                XStart = Position.X - i 'Make the new x-int
            End If
            If Position.X + i <= 26 Then
                XEnd = Position.X + i 'Make the new XEnd
            End If
            If Position.Y - i >= 0 Then
                YStart = Position.Y - i 'Make the new y-int
            End If
            If Position.Y + i <= 9 Then
                YEnd = Position.Y + i 'Make the new YEnd
            End If
        Next
        '---------------------------------

        '-----Make connections-----
        For X As Integer = XStart To XEnd
            For Y As Integer = YStart To YEnd
                If P.Sectors(X, Y) IsNot Nothing Then 'The sector isn't empty
                    ReDim Preserve Connections(Connections.Length) 'Add a blank space
                    Connections(UBound(Connections)) = New wormhole(Me, New Point(X, Y), False) 'Add the wormhole
                End If
            Next
        Next
        '--------------------------
    End Sub

    Public Sub Viable()
        Checked = True
        For X As Integer = Position.X - 4 To Position.X + 4
            If X <= 0 And X >= 26 Then
                For Y As Integer = Position.Y - 4 To Position.Y + 4
                    If P.Sectors(X, Y) IsNot Nothing Then
                        If P.Sectors(X, Y).Checked = False Then
                            P.Sectors(X, Y).Viable()
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Public Overrides Sub Clicked(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then 'They want to Interact the starSystem
            '-------------------------------------------------
            galaxyTile.Zoom = galaxyTile.ZoomLevels.System
            For Each i As sector In P.Sectors
                If i IsNot Nothing Then
                    i.Graphic.Reference = Nothing
                    i.Graphic.Update()
                End If
            Next
            For Each i As starSystem In Systems
                If i IsNot Nothing Then
                    i.Graphic.Reference = i
                    i.Graphic.Update()
                End If
            Next
            P.FleetToMove = Nothing
            P.MakingWormhole = Nothing
            P.AddingShips = Nothing
            Exit Sub
            '-------------------------------------------------
        ElseIf e.Button = MouseButtons.Left And P.AddingShips = True Then
            If Friendly = Galaxy.Allegence.Friendly Then 'Its player owned
                Dim Temp As New AddingShipsStep1(Fleets, Me)
                P.FleetToMove = Nothing
                P.MakingWormhole = Nothing
                P.AddingShips = Nothing
                P.P.Enabled = False
            End If

        ElseIf e.Button = MouseButtons.Left And P.MakingWormhole = True Then
            If Friendly = Galaxy.Allegence.Friendly Then 'Its player owned
                Dim Temp As New MakingWormholes(Me)
                P.FleetToMove = Nothing
                P.MakingWormhole = Nothing
                P.AddingShips = Nothing
                P.P.Enabled = False
            End If

        ElseIf e.Button = MouseButtons.Left And e.Clicks = 2 Then  'Move or select fleets
            '-------------------------------------------------
            If P.FleetToMove Is Nothing Then 'there are no fleets selected
                If Fleets.Length <> 0 Then 'Theres ships inside the sector
                    Dim GoOn As Boolean = False
                    For Each i As fleet In Fleets
                        If i.Friendly = Galaxy.Allegence.Friendly Then 'Theres player owned fleets
                            GoOn = True
                        End If
                        Exit For
                    Next

                    If GoOn = True Then 'Start Selecting fleets
                        Dim Selecting As New SelectingFleets(Me, Fleets)
                        P.P.Pause_Click(Me, New EventArgs)
                        P.P.Enabled = False
                    End If
                End If
            Else 'There are fleets selected
                If Highlighted = True Then 'If its highlighted
                    If Battle Is Nothing Then
                        For Each i As wormhole In P.FleetToMove.P.Connections
                            P.Sectors(i.Opening.X, i.Opening.Y).Highlighted = False
                        Next
                        P.FleetToMove.P.Remove_Fleet(P.FleetToMove) 'Remove the old reference
                        Add_Fleet(P.FleetToMove) 'Add the new fleet
                        P.FleetToMove.P.Position = Position 'Set the fleets new position
                    End If
                    P.FleetToMove = Nothing
                    P.MakingWormhole = Nothing
                    P.AddingShips = Nothing
                End If
            End If
            '-------------------------------------------------
        End If

        Dim Str As String
        '-----Calculating Stats-----
        '-----Getting Allegence-----
        If Friendly = Galaxy.Allegence.Enemy Then
            Str = "Enemy"
        ElseIf Friendly = Galaxy.Allegence.Friendly Then
            Str = "Player"
        Else
            Str = "Nil"
        End If
        Info = "Sector Allegence: " + Str + Environment.NewLine
        '---------------------------

        '-----Counting Systems-----
        Dim count1 As Integer
        Dim count2 As Integer
        For Each i As starSystem In Systems
            If i IsNot Nothing Then
                If i.Friendly = Galaxy.Allegence.Neutral Then
                    count1 = count1 + 1
                Else
                    count2 = count2 + 1
                End If
            End If
        Next
        Info = Info + "Uncolonised Systems: " + CStr(count1) + Environment.NewLine +
            "Colonised Systems: " + CStr(count2) + Environment.NewLine
        '--------------------------

        '-----Counting Ships-----
        Dim count(ship.Ship_Types.Max - 1) As Integer 'the number of each type of ship in the fleet
        For Each i As fleet In Fleets
            For Each f As ship In i.Ships
                count(f.Type) = count(f.Type) + 1 'Add to the count
            Next
        Next
        Info = Info + "Fighters: " + CStr(count(ship.Ship_Types.Fighter)) + Environment.NewLine +
            "Bombers: " + CStr(count(ship.Ship_Types.Bomber)) + Environment.NewLine +
            "Frigates: " + CStr(count(ship.Ship_Types.Frigate)) + Environment.NewLine +
            "Destroyers: " + CStr(count(ship.Ship_Types.Destroyer)) + Environment.NewLine +
            "Cruisers: " + CStr(count(ship.Ship_Types.Cruiser)) + Environment.NewLine +
            "Dreadnoughts: " + CStr(count(ship.Ship_Types.Dreadnought))
        '------------------------
        '------------------------

        P.P.StatDisplay.Text = Info
        Graphic.Update()
    End Sub

    Public Sub Add_Fleet(ByRef NFleet As fleet)
        ReDim Preserve Fleets(Fleets.Length) 'Add an extra space
        Fleets(UBound(Fleets)) = NFleet 'Add the new fleet
        NFleet.P.Position = Position 'Set the new position
        NFleet.P = Me 'Make me the parent

        If Friendly <> Galaxy.Allegence.Neutral And NFleet.Friendly <> Friendly Then 'Start a battle
            Battle = Nothing
            For Each i As fleet In Fleets
                i.Update(True)
            Next
            Battle = New Combat(Me)
        End If
    End Sub

    Public Sub Remove_Fleet(ByRef Nfleet As fleet)
        Dim Index As Integer = Array.IndexOf(Fleets, Nfleet) 'The index of the fleet
        For i As Integer = Index To UBound(Fleets)
            If i <> UBound(Fleets) Then
                Fleets(i) = Fleets(i + 1) 'Move the rest of the Fleets back
            End If
        Next
        ReDim Preserve Fleets(UBound(Fleets) - 1) 'Remove the empty space from the list

        '-----Check Allegence-----
        Dim Friendlies As Integer
        Dim Enemies As Integer
        For Each i As fleet In Fleets
            If i.Friendly = Galaxy.Allegence.Friendly Then
                Friendlies = Friendlies + 1
            ElseIf i.Friendly = Galaxy.Allegence.Enemy Then
                Enemies = Enemies + 1
            End If
        Next
        For Each i As starSystem In Systems
            If i IsNot Nothing Then
                If i.Friendly = Galaxy.Allegence.Friendly Then
                    Friendlies = Friendlies + 1
                ElseIf i.Friendly = Galaxy.Allegence.Enemy Then
                    Enemies = Enemies + 1
                End If
            End If
        Next
        If Friendlies > Enemies Then
            Friendly = Galaxy.Allegence.Friendly
        ElseIf Enemies > Friendlies Then
            Friendly = Galaxy.Allegence.Enemy
        Else
            Friendly = Galaxy.Allegence.Neutral
        End If
        '-------------------------

        If Object.ReferenceEquals(Nfleet, P.FleetToMove) Then
            For Each i As wormhole In Connections
                P.Sectors(i.Opening.X, i.Opening.Y).Highlighted = False
                P.Sectors(i.Opening.X, i.Opening.Y).Graphic.Update()
            Next
        End If
        For Each i As wormhole In Connections
            i.Update()
        Next
    End Sub

    Public Overrides Sub Update()

        '-----Battle-----
        If Battle IsNot Nothing Then 'Theres a battle
            Battle.Update() 'Update the battle
            Friendly = Galaxy.Allegence.Neutral 'Reset the sectors allegence
            Dim Friendlies As Integer 'The number of friendly ships
            Dim Enemies As Integer 'The number of enemy ships
            For Each i As fleet In Fleets
                If Equals(i, Nothing) = False Then
                    If i.Friendly = Galaxy.Allegence.Friendly Then
                        Friendlies = Friendlies + i.ShipCount
                    ElseIf i.Friendly = Galaxy.Allegence.Enemy Then
                        Enemies = Enemies + i.ShipCount
                    End If
                End If
            Next
            If Friendlies > Enemies Then
                Friendly = Galaxy.Allegence.Friendly
            ElseIf Enemies > Friendlies Then
                Friendly = Galaxy.Allegence.Enemy
            End If
        ElseIf Fleets.Length <> 0 Then
            Friendly = Fleets(0).Friendly
            '-----Update fleets-----
            If Fleets.Length <> 0 Then 'If there is a fleet
                For Each i As fleet In Fleets
                    i.Update(False) 'Update the fleet
                Next
            End If
            '-----------------------
        End If
        '----------------

        '-----Systems-----
        For Each i As starSystem In Systems
            If i IsNot Nothing Then
                If i.Friendly = Galaxy.Allegence.Friendly Then
                    i.Update()
                End If
                If i.Friendly <> Galaxy.Allegence.Neutral And i.Friendly <> Friendly Then
                    i.Friendly = Galaxy.Allegence.Neutral
                End If
            End If
        Next
        '-----------------

        '-----Wormholes-----
        If Friendly <> Galaxy.Allegence.Friendly Then 'Its an enemy sector
            For Each i As wormhole In Connections
                If i.Artificial = True Then
                    i.Remove_Wormhole()
                End If
            Next
        End If

        For Each i As wormhole In Connections
            i.Update()
        Next
        '-------------------

        If galaxyTile.Zoom = galaxyTile.ZoomLevels.System Then
            For Each i As starSystem In Systems
                If i IsNot Nothing Then
                    i.Graphic.Update()
                End If
            Next
        Else
            Graphic.Update()
        End If
    End Sub

    Public Sub ZoomOut()
        P.P.StatDisplay.Text = ""
        galaxyTile.Zoom = galaxyTile.ZoomLevels.Sector
        For Each i As starSystem In Systems
            If i IsNot Nothing Then
                i.Graphic.Reference = Nothing
                i.Graphic.Update()
            End If
        Next
        For Each i As sector In P.Sectors
            If i IsNot Nothing Then
                i.Graphic.Reference = i
                i.Graphic.Update()
            End If
        Next
    End Sub

End Class
