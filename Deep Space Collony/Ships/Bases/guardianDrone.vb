Public Class guardianDrone
    Inherits ship

    Public Shared Guardian_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 10},
        {Ship_Stats.Armour, 15},
        {Ship_Stats.Accuracy, 15},
        {Ship_Stats.Damage, 30},
        {Ship_Stats.Shots, 4},
        {Ship_Stats.Weight, 1},
        {Ship_Stats.Drones, 0}
    }

    Public Sub New()
        For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In Guardian_Stats
            Stats(i.Key) = i.Value
        Next
        Stats(Ship_Stats.MaximumShields) = Guardian_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.GuardianDrone
    End Sub

    Public Overrides Sub Update()
        MyBase.Update()
        If P.P.Battle Is Nothing Then
            Kill_Ship()
        End If
    End Sub

End Class
