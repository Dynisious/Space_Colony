Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class destroyer
    Inherits ship

    Public Shared Destroyer_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.MaximumShields, 40},
        {Ship_Stats.Armour, 40},
        {Ship_Stats.Accuracy, 20},
        {Ship_Stats.Damage, 65},
        {Ship_Stats.Shots, 1},
        {Ship_Stats.Weight, 2},
        {Ship_Stats.Drones, 0}
    }
    Public Shared Destroyer_Costs As New Dictionary(Of Galaxy.Produce, Integer) From {
        {Galaxy.Produce.Resource, 4800},
        {Galaxy.Produce.Gas, 1067}
    }


    Public Sub New()
        For Each i In Destroyer_Stats
            Stats(i.Key) = Destroyer_Stats(i.Key)
        Next
        For Each i In Destroyer_Costs
            Costs(i.Key) = Destroyer_Costs(i.Key)
        Next
        Stats(Ship_Stats.MaximumShields) = Destroyer_Stats(Ship_Stats.MaximumShields)
        Type = Ship_Types.Destroyer
    End Sub

End Class
