Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class fleet
    Public P As sector
    Public Ships(-1) As ship
    Public ShipCount As Integer
    Public DroneCount As Integer
    Public Friendly As Galaxy.Allegence
    Public Position As Point
    Public TickCount As Integer

    Public Sub New(ByRef NParent As sector, ByRef NShip As ship, ByVal NPosition As Point, ByVal NFriendly As Galaxy.Allegence)
        P = NParent
        Add_Ship(NShip)
        Position = NPosition
        Friendly = NFriendly
    End Sub

    Public Sub Add_Ship(ByRef NShip As ship)
        ReDim Preserve Ships(Ships.Length) 'Add a space
        Ships(UBound(Ships)) = NShip 'Add the new ship
        Ships(UBound(Ships)).P = Me 'Make me the parent
        ShipCount = ShipCount + NShip.Stats(ship.Ship_Stats.Weight)  'Add to the ship count
        DroneCount = DroneCount + NShip.Stats(ship.Ship_Stats.Drones) 'Add the drones
    End Sub

    Public Sub Remove_Ship(ByRef NShip As ship)
        Dim Index As Integer = -1 'The index of the Ship
        Dim f As Integer = 0
        Do Until Index <> -1
            If ReferenceEquals(Ships(f), NShip) Then
                Index = f
            Else
                f = f + 1
            End If
        Loop
        ReDim Preserve Ships(Ships.Length) 'Add an extra space
        Ships(UBound(Ships)) = Ships(Index) 'Move it to the end of the list
        ShipCount = ShipCount - Ships(Index).Stats(ship.Ship_Stats.Weight) 'Remove the points from the count
        DroneCount = DroneCount - Ships(Index).Stats(ship.Ship_Stats.Drones) 'Remove the drones from the count
        Ships(Index) = Nothing 'Delete the old reference
        For i As Integer = Index To UBound(Ships) - 1
            Ships(i) = Ships(i + 1) 'Move the rest of the Ships back
        Next
        ReDim Preserve Ships(Ships.Length - 3) 'Remove the empty space and ship from the list
        If ShipCount = 0 Then 'Theres no Ships
            Kill()
        End If
    End Sub

    Public Sub LaunchDrones()
        If DroneCount <> 0 Then
            For i As Integer = 1 To DroneCount
                Add_Ship(New guardianDrone)
            Next
        End If
    End Sub

    Public Overridable Sub Update(ByVal InBattle As Boolean)
        TickCount = TickCount + 1
        If TickCount = 100 Or InBattle = True Then 'Its been a second or its in a battle
            TickCount = 0
            Dim GoOn As Boolean = False
            For Each i As ship In Ships
                If i.Type <> ship.Ship_Types.GuardianDrone Then
                    GoOn = True
                End If
            Next
            If GoOn = True Then 'Theres ships 
                For Each i As ship In Ships
                    If Equals(i, Nothing) = False Then
                        i.Update()
                    End If
                Next
            Else 'Theres only drones
                For Each i As ship In Ships
                    i.Kill_Ship()
                Next
                Kill()
            End If
        End If
    End Sub

    Public Overridable Sub Kill()
        P.Remove_Fleet(Me)
        If Object.ReferenceEquals(Me, Screen.GameGalaxy.FleetToMove) = True Then 'Im selected
            Screen.GameGalaxy.FleetToMove = Nothing
            For Each i As wormhole In P.Connections
                i.P.Highlighted = False
            Next
        End If
        P = Nothing
    End Sub

End Class
