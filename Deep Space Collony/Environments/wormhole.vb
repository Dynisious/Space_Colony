Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class wormhole
    Public P As sector
    Public Opening As Point
    Public Closed As Boolean = False
    Private UpdateTick As Integer

    Public Sub New(ByRef NParent As sector, ByVal NOpening As Point)
        P = NParent
        Opening = NOpening
    End Sub

    Public Sub Update()
        UpdateTick = UpdateTick + 1
        If UpdateTick = 100 Then 'Its been a second
            If Closed = True Then
                If P.P.ProduceStores(Galaxy.Produce.Resource) >= 6 Then
                    P.P.ProduceStores(Galaxy.Produce.Resource) =
                        P.P.ProduceStores(Galaxy.Produce.Resource) - 6
                Else
                    P.P.ProduceStores(Galaxy.Produce.Resource) = 0
                    Closed = False
                End If
            End If
            UpdateTick = 0
        End If
    End Sub

End Class
