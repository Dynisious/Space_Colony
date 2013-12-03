Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class artificialWormhole
    Inherits wormhole
    Public UpdateTick As Integer
    Private Friendly As Galaxy.Allegence

    Public Sub New(ByRef NParent As sector, ByVal NOpening As Point, ByVal NArtificial As Boolean, ByVal NFriendly As Galaxy.Allegence)
        MyBase.New(NParent, NOpening, NArtificial)
        Friendly = NFriendly
    End Sub

    Public Overrides Sub Update()
        MyBase.Update()

        If P.Friendly <> Friendly Then
            Remove_Wormhole()
        End If
        If UpdateTick = 200 And Friendly = Galaxy.Allegence.Friendly Then 'Its been two seconds
            UpdateTick = 0
            If P.P.ProduceStores(Galaxy.Produce.Gas) >= 5 Then 'Pay
                P.P.ProduceStores(Galaxy.Produce.Gas) =
                    P.P.ProduceStores(Galaxy.Produce.Gas) - 5
            Else 'Remove wormhole
                P.P.ProduceStores(Galaxy.Produce.Gas) = 0
                Remove_Wormhole()
            End If
            UpdateTick = 0
        End If
    End Sub

End Class
