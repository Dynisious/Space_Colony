Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class starSystem
    Inherits BaseSpace
    Public WithEvents P As sector 'The Sector the system is contained in
    Public Position As Point 'The Position of the system inside the sector
    Public Enum SystemTypes 'The types of StarSystems
        Solar
        Nebula
    End Enum
    Public Type As SystemTypes
    Private Info As String
    Private Discription As String
    Private ReadOnly Discriptions As New Dictionary(Of Integer, String) From {
            {1, "A Sun and a few simple planets although some of them could" +
                " provide valuble scientific reasearch; others appear sutable" +
                " for crops" + Environment.NewLine + "Resource/min: 120" +
                Environment.NewLine + "Science points/min: 20"},
            {2, "Deep scans are detecting large metal deposits close to the " +
                "surface. A mining colony here could be very " +
                "profitable, plus I'm sure the science team could find some " +
                "pretty rocks to test." + Environment.NewLine + "Resource/min: 120" +
                Environment.NewLine + "Science points/min: 20"},
            {3, "Some of the planets here are populated with simple animal life. " +
                "By Terra the scientists would have a field day and I'm sure the sh" +
                "ips cook could work some magic." + Environment.NewLine +
                "Resource/min: 120" + Environment.NewLine + "Science points/min: 20"},
            {4, "This nebula, though small, is composed purely of aurum-caligo " +
                "gas! oh what a find! This nebula could easily be harvested for " +
                "a great turn out as it would require no refinement." +
                Environment.NewLine + "Gas/min: 120"},
            {5, "The observation deck is filled with the light this gas giant " +
                "is throwing off. A small operation could turn " +
                "this raw aurum gas into usable fuel. The tanks " +
                "are looking a bit dry and a refuel would be appresiated." +
                Environment.NewLine + "Gas/min: 120"},
            {6, "Finding this cloud of aurum gas was terrorfying. A swirl" +
                "ing purple vortex of light that would tear this ship appart." +
                " I might call in a team; It's sad " +
                "really that gas teams can go somewhere I " +
                "wouldn't dare fly this grand war ship." + Environment.NewLine +
                "Gas/min: 120"}
        }
    Public UpdateTick As Integer
    Public ScienceTick As Integer

    Public Sub New(ByRef NParent As sector, ByVal NPosition As Point)
        P = NParent
        Position = NPosition
        Friendly = Galaxy.Allegence.Neutral
        '-----Set the Type-----
        Randomize()
        If Int(6 * Rnd()) = 0 Then 'Should it be a Nebula
            'Yes it should be a Nebula
            Type = SystemTypes.Nebula
            Discription = Discriptions(Int((3 * Rnd()) + 4))
        Else
            'No it should be a Solar System
            Type = SystemTypes.Solar
            Discription = Discriptions(Int((3 * Rnd()) + 1))
        End If
        '----------------------

    End Sub

    Public Overrides Sub Clicked(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left And e.Clicks = 2 Then 'Colonize the starSystem
            If P.Friendly = Galaxy.Allegence.Friendly Then 'Its player owned
                If P.P.ProduceStores(Galaxy.Produce.Resource) >= 60 Then 'You have the supplies
                    '-----Colonise-----
                    P.P.ProduceStores(Galaxy.Produce.Resource) =
                        P.P.ProduceStores(Galaxy.Produce.Resource) - 60 'Remove the resources
                    Friendly = Galaxy.Allegence.Friendly 'Make player owned
                    '------------------
                End If
            End If
        ElseIf e.Button = MouseButtons.Right Then 'Zoom out
            P.ZoomOut()
        End If

        Dim Str As String
        '-----Calculating Stats-----
        '-----Getting Allegence-----
        If Friendly = Galaxy.Allegence.Enemy Then
            Str = "Enemy"
        ElseIf Friendly = Galaxy.Allegence.Friendly Then
            Str = "Player"
        Else
            Str = "Nil"
        End If
        Info = "System Allegence: " + Str + Environment.NewLine
        '---------------------------

        '-----Getting Type-----
        Select Case Type
            Case SystemTypes.Solar
                Str = "Solar System"
            Case SystemTypes.Nebula
                Str = "Nebula"
        End Select
        Info = Info + "System Type: " + Str + Environment.NewLine +
            "Cost to Collonise: 60 Resource" + Environment.NewLine +
            "Discription: " + Discription
        '----------------------
        '---------------------------

        P.P.P.StatDisplay.Text = Info

        Graphic.Update()
    End Sub

    Public Overrides Sub Update()
        If Friendly = Galaxy.Allegence.Friendly Then 'Its player owned
            UpdateTick = UpdateTick + 1
            If UpdateTick = 100 Then 'If its been a second
                UpdateTick = 0 'Reset the count
                If Type = SystemTypes.Solar Then 'Its a Solar System
                    'Add resource
                    P.P.ProduceStores(Galaxy.Produce.Resource) = P.P.ProduceStores(Galaxy.Produce.Resource) + 2
                    'Add Science
                    ScienceTick = ScienceTick + 1
                    If ScienceTick = 3 Then 'its been three seconds
                        P.P.ProduceStores(Galaxy.Produce.Science) = P.P.ProduceStores(Galaxy.Produce.Science) + 1
                    End If
                Else 'Its a Nebula
                    'Add Gas
                    P.P.ProduceStores(Galaxy.Produce.Gas) = P.P.ProduceStores(Galaxy.Produce.Gas) + 2
                End If
            End If
        End If
    End Sub

End Class
