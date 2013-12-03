Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public MustInherit Class ship
    Public P As fleet
    Public Health As Integer = 100 'The health of the ship
    Public Shields As Integer 'The shields of the ship
    Public Enum Ship_Stats
        MaximumShields 'The maximum shield power
        Armour 'The ships % chance to block a hit
        Accuracy 'The ships % chance to land a hit
        Damage 'The ships damage
        Shots 'How many times the ship shoots per attack
        Weight 'How big the ship is
        Drones 'How many drones it deploys
    End Enum
    Public Stats As New Dictionary(Of Ship_Stats, Integer)
    Public Costs As New Dictionary(Of Galaxy.Produce, Integer)
    Public Enum Ship_Types
        Fighter
        Bomber
        Frigate
        Destroyer
        Cruiser
        Dreadnought
        OrbitalGun
        GuardianDrone
        Max
    End Enum
    Public Type As Ship_Types 'The type of ship it is
    Private TickCount As Integer 'How many ticks have past

    Public Sub Attack(ByRef Target As ship)
        For i As Integer = 1 To Stats(Ship_Stats.Shots)
            Randomize()
            If Int((100 * Rnd()) + 1) <= Stats(Ship_Stats.Accuracy) Then 'Does it land the hit
                Target.Defend(Me)
            End If
        Next
    End Sub

    Public Sub Defend(ByRef Attacker As ship)
        Randomize()
        If Shields > 0 Then 'If there are shields
            Shields = Shields - Attacker.Stats(Ship_Stats.Damage) 'Shields take hit
        Else 'There are no shields
            If Int((100 * Rnd()) + 1) > Stats(Ship_Stats.Armour) Then 'I miss the block
                Health = Health - Attacker.Stats(Ship_Stats.Damage) 'Health takes hit
            End If
            If Health <= 0 Then 'If there is no health left
                Kill_Ship()
            End If
        End If
    End Sub

    Public Sub Kill_Ship()
        If Equals(P, Nothing) = False Then
            P.Remove_Ship(Me)
            P = Nothing
        End If
    End Sub

    Public Overridable Sub Update(ByVal InBattle As Boolean)
        If InBattle = True Then 'theres a battle
            If Shields < Stats(Ship_Stats.MaximumShields) Then 'if the shields aren't full
                Shields = Shields + 1
            End If
        Else 'Theres no battle
            If Health < 100 Then 'If the ship is damaged
                Health = Health + 1
            End If
        End If
    End Sub

End Class
