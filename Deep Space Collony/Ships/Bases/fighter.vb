Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class fighter
    Inherits ship
    Public Shared Fighter_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 10},
        {Ship_Stats.Armour, 5},
        {Ship_Stats.Accuracy, 20},
        {Ship_Stats.Damage, 15},
        {Ship_Stats.Shots, 4},
        {Ship_Stats.Weight, 1},
        {Ship_Stats.Drones, 0}
    }
    Public Shared Fighter_Costs As New Dictionary(Of Galaxy.Produce, Integer) From {
        {Galaxy.Produce.Resource, 800},
        {Galaxy.Produce.Gas, 0}
    }

    Public Sub New()
        For Each i In Fighter_Stats
            Stats(i.Key) = Fighter_Stats(i.Key)
        Next
        For Each i In Fighter_Costs
            Costs(i.Key) = Fighter_Costs(i.Key)
        Next
        Stats(Ship_Stats.MaximumShields) = Fighter_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.Fighter
    End Sub

End Class
