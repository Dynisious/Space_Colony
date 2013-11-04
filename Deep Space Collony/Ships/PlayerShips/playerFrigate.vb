Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class playerFrigate
    Inherits Frigate
    Public Shared PFrigate_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.Accuracy, 0},
        {Ship_Stats.Armour, 0},
        {Ship_Stats.Damage, 0},
        {Ship_Stats.MaximumShields, 0},
        {Ship_Stats.Shots, 0}
    }

    Public Sub New()
        MyBase.New()
        For Each i As KeyValuePair(Of Ship_Stats, Integer) In PFrigate_Stats
            Stats(i.Key) = Stats(i.Key) + PFrigate_Stats(i.Key)
        Next
    End Sub

End Class
