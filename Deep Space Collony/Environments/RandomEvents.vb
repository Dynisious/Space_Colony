Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class RandomEvents
    Public Shared P As Galaxy

    Public Sub New(ByRef NParent As Galaxy)
        P = NParent
    End Sub

    Public Shared Sub Black_Hole(ByRef Sec As sector)
        For Each e As starSystem In Sec.Systems 'every system in the sector
            If Equals(e, Nothing) = False Then
                e.Friendly = Galaxy.Allegence.Neutral
            End If
        Next
        If Sec.Fleets.Length <> 0 Then 'Theres fleets
            For Each e As fleet In Sec.Fleets 'every fleet in the sector
                For Each f As ship In e.Ships
                    e.P = Nothing
                Next
                ReDim e.Ships(-1)
            Next
            ReDim Sec.Fleets(-1)
        End If
        For Each e As wormhole In Sec.Connections
            If e.Artificial = True Then
                e.Remove_Wormhole()
            End If
        Next
        Sec.Friendly = Galaxy.Allegence.Neutral 'Make the sector neutral
        Sec.Graphic.Update()
    End Sub

End Class
