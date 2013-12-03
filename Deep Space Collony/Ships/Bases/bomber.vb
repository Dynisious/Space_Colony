Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class bomber
    Inherits ship

    Public Shared Bomber_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 10},
        {Ship_Stats.Armour, 5},
        {Ship_Stats.Accuracy, 10},
        {Ship_Stats.Damage, 80},
        {Ship_Stats.Shots, 2},
        {Ship_Stats.Weight, 1},
        {Ship_Stats.Drones, 1}
    }
    Public Shared Bomber_Costs As New Dictionary(Of Galaxy.Produce, Integer) From {
        {Galaxy.Produce.Resource, 933},
        {Galaxy.Produce.Gas, 533}
    }


    Public Sub New()
        For Each i In Bomber_Stats
            Stats(i.Key) = Bomber_Stats(i.Key)
        Next
        For Each i In Bomber_Costs
            Costs(i.Key) = Bomber_Costs(i.Key)
        Next
        Stats(Ship_Stats.MaximumShields) = Bomber_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.Bomber
    End Sub

End Class
