Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class wormhole
    Public P As sector
    Public Opening As Point
    Public Artificial As Boolean

    Public Sub New(ByRef NParent As sector, ByVal NOpening As Point, ByVal NArtificial As Boolean)
        P = NParent
        Opening = NOpening
        Artificial = NArtificial
    End Sub

    Public Sub Remove_Wormhole()
        Dim Index As Integer = Array.IndexOf(P.Connections, Me) 'My index
        For i As Integer = Index To UBound(P.Connections) 'Move the other wormholes back
            If i <> UBound(P.Connections) Then
                P.Connections(i) = P.Connections(i + 1)
            End If
        Next
        ReDim Preserve P.Connections(UBound(P.Connections) - 1) 'Remove the spare space
    End Sub

    Public Sub Add_Wormhole()
        ReDim Preserve P.Connections(P.Connections.Length)
        P.Connections(UBound(P.Connections)) = Me
    End Sub

    Public Overridable Sub Update()

    End Sub

End Class
