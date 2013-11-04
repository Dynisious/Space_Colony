Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class playerDreadnought
    Inherits dreadnought
    Public Shared PDreadnought_Stats As New Dictionary(Of Ship_Stats, Integer) From {
        {Ship_Stats.Accuracy, 0},
        {Ship_Stats.Armour, 0},
        {Ship_Stats.Damage, 0},
        {Ship_Stats.MaximumShields, 0},
        {Ship_Stats.Shots, 0}
    }

    Public Sub New()
        MyBase.New()
        For Each i As KeyValuePair(Of Ship_Stats, Integer) In PDreadnought_Stats
            Stats(i.Key) = Stats(i.Key) + PDreadnought_Stats(i.Key)
        Next
    End Sub

End Class
