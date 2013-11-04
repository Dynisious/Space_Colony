Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class tutorialGalaxy
    Inherits Galaxy

    Public Sub New(ByRef NParent As Screen)
        MyBase.New(NParent)
        WorldTimer.Interval = 20
        ProduceStores(Produce.Resource) = 100000000
        ProduceStores(Produce.Gas) = 100000000
    End Sub

    Public Overrides Sub LoadGame(ByRef NParent As Screen)
        MyBase.LoadGame(NParent)
        WorldTimer.Interval = 100
    End Sub

End Class
