Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class Combat
    Public Fleets() As fleet 'The List of fleets in combat
    Public P As sector 'The sector the battle is held in

    Public Sub New(ByRef NParent As sector)
        P = NParent

        For Each i As fleet In P.Fleets
            i.LaunchDrones()
        Next
    End Sub

    Public Sub Update()
        '-----Check if the battle should continue-----
        Fleets = P.Fleets 'Reset the fleets
        Dim GoOn As Boolean = False
        Dim FleetToCheck As fleet = Fleets(0)
        For Each i As fleet In Fleets
            If Equals(i, Nothing) = False Then
                If i.Friendly <> FleetToCheck.Friendly Then 'Theres different allegencies
                    GoOn = True
                    Exit For
                End If
            End If
        Next
        '---------------------------------------------

        If GoOn = True Then 'Battle
            For Each i As fleet In Fleets
                i.Update(True)
            Next
            Randomize()
            Dim Defender As fleet = Fleets(Int(Fleets.Length * Rnd())) 'The defending fleet
            Dim Attacker As fleet = Fleets(Int(Fleets.Length * Rnd())) 'The attacking fleet
            If Attacker.Friendly <> Defender.Friendly Then 'They're enemies
                For Each i As ship In Attacker.Ships
                    If Defender.Ships.Length <> 0 Then 'Theres ships left
                        Dim Target As ship = Defender.Ships(Int(Defender.Ships.Length * Rnd())) 'A ship in the defending fleet
                        i.Attack(Target) 'Attack ship
                    Else
                        Exit Sub
                    End If
                Next
            End If
        Else 'End battle
            P.Battle = Nothing
            For Each i As fleet In P.Fleets
                i.Update(True)
            Next
        End If
    End Sub

End Class
