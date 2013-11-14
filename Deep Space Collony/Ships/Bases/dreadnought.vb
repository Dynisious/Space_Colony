Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class dreadnought
    Inherits ship

    Public Shared Dreadnought_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 100},
        {Ship_Stats.Armour, 60},
        {Ship_Stats.Accuracy, 80},
        {Ship_Stats.Damage, 80},
        {Ship_Stats.Shots, 1},
        {Ship_Stats.Weight, 3},
        {Ship_Stats.Drones, 5}
    }
    Public Shared Dreadnought_Costs As New Dictionary(Of Galaxy.Produce, Integer) From {
        {Galaxy.Produce.Resource, 5500},
        {Galaxy.Produce.Gas, 2000}
    }


    Public Sub New()
        For Each i In Dreadnought_Stats
            Stats(i.Key) = Dreadnought_Stats(i.Key)
        Next
        For Each i In Dreadnought_Costs
            Costs(i.Key) = Dreadnought_Costs(i.Key)
        Next
        Stats(Ship_Stats.MaximumShields) = Dreadnought_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.Dreadnought
    End Sub

End Class
