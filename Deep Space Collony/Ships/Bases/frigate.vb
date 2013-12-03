Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class frigate
    Inherits ship

    Public Shared Frigate_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 25},
        {Ship_Stats.Armour, 15},
        {Ship_Stats.Accuracy, 20},
        {Ship_Stats.Damage, 25},
        {Ship_Stats.Shots, 2},
        {Ship_Stats.Weight, 2},
        {Ship_Stats.Drones, 0}
    }
    Public Shared Frigate_Costs As New Dictionary(Of Galaxy.Produce, Integer) From {
        {Galaxy.Produce.Resource, 1600},
        {Galaxy.Produce.Gas, 0}
    }


    Public Sub New()
        For Each i In Frigate_Stats
            Stats(i.Key) = Frigate_Stats(i.Key)
        Next
        For Each i In Frigate_Costs
            Costs(i.Key) = Frigate_Costs(i.Key)
        Next
        Stats(Ship_Stats.MaximumShields) = Frigate_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.Frigate
    End Sub

End Class
