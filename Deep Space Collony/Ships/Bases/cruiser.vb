Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class cruiser
    Inherits ship

    Public Shared Cruiser_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 75},
        {Ship_Stats.Armour, 80},
        {Ship_Stats.Accuracy, 50},
        {Ship_Stats.Damage, 45},
        {Ship_Stats.Shots, 1},
        {Ship_Stats.Weight, 3},
        {Ship_Stats.Drones, 3}
    }
    Public Shared Cruiser_Costs As New Dictionary(Of Galaxy.Produce, Integer) From {
        {Galaxy.Produce.Resource, 6000},
        {Galaxy.Produce.Gas, 1600}
    }


    Public Sub New()
        For Each i In Cruiser_Stats
            Stats(i.Key) = Cruiser_Stats(i.Key)
        Next
        For Each i In Cruiser_Costs
            Costs(i.Key) = Cruiser_Costs(i.Key)
        Next
        Stats(Ship_Stats.MaximumShields) = Cruiser_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.Cruiser
    End Sub

End Class
