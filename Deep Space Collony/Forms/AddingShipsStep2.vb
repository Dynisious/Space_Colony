Public Class AddingShipsStep2
    Public P As sector
    Public Fleet As fleet
    Public ResourceCost As Integer
    Public GasCost As Integer
    Public ShipCount As Integer
    Public MaxShipCount As Integer
    Private WithEvents T As New Timer With {.Enabled = True, .Interval = 100}
    Public Sub New(ByRef NFleet As fleet, ByRef NParent As sector)
        InitializeComponent()

        '-----Display Costs-----
        lblFighters.Text =
            "Fighters: " + CStr(fighter.Fighter_Costs(Galaxy.Produce.Resource)) +
            "/" + CStr(fighter.Fighter_Costs(Galaxy.Produce.Gas))
        lblBombers.Text =
            "Bomber: " + CStr(bomber.Bomber_Costs(Galaxy.Produce.Resource)) +
            "/" + CStr(bomber.Bomber_Costs(Galaxy.Produce.Gas))
        lblFrigates.Text =
            "Frigate: " + CStr(Frigate.Frigate_Costs(Galaxy.Produce.Resource)) +
            "/" + CStr(Frigate.Frigate_Costs(Galaxy.Produce.Gas))
        lblDestroyers.Text =
            "Destroyer: " + CStr(destroyer.Destroyer_Costs(Galaxy.Produce.Resource)) +
            "/" + CStr(destroyer.Destroyer_Costs(Galaxy.Produce.Gas))
        lblCruisers.Text =
            "Cruiser: " + CStr(cruiser.Cruiser_Costs(Galaxy.Produce.Resource)) +
            "/" + CStr(cruiser.Cruiser_Costs(Galaxy.Produce.Gas))
        lblDreadnoughts.Text =
            "Dreadnought: " + CStr(dreadnought.Dreadnought_Costs(Galaxy.Produce.Resource)) +
            "/" + CStr(dreadnought.Dreadnought_Costs(Galaxy.Produce.Gas))
        '-----------------------

        Visible = True
        P = NParent
        Fleet = NFleet
    End Sub

    Private Sub UpdateCosts() Handles T.Tick
        ResourceCost = (NumFighters.Value * fighter.Fighter_Costs(Galaxy.Produce.Resource)) +
            (NumBombers.Value * bomber.Bomber_Costs(Galaxy.Produce.Resource)) +
            (NumFrigates.Value * Frigate.Frigate_Costs(Galaxy.Produce.Resource)) +
            (NumDestroyers.Value * destroyer.Destroyer_Costs(Galaxy.Produce.Resource)) +
            (NumCruisers.Value * cruiser.Cruiser_Costs(Galaxy.Produce.Resource)) +
            (NumDreadnoughts.Value * dreadnought.Dreadnought_Costs(Galaxy.Produce.Resource))
        GasCost = (NumFighters.Value * fighter.Fighter_Costs(Galaxy.Produce.Gas)) +
            (NumBombers.Value * bomber.Bomber_Costs(Galaxy.Produce.Gas)) +
            (NumFrigates.Value * frigate.Frigate_Costs(Galaxy.Produce.Gas)) +
            (NumDestroyers.Value * destroyer.Destroyer_Costs(Galaxy.Produce.Gas)) +
            (NumCruisers.Value * cruiser.Cruiser_Costs(Galaxy.Produce.Gas)) +
            (NumDreadnoughts.Value * dreadnought.Dreadnought_Costs(Galaxy.Produce.Gas))
        ShipCount = (NumFighters.Value + NumBombers.Value) + ((NumFrigates.Value +
            NumDestroyers.Value) * frigate.Frigate_Stats(ship.Ship_Stats.Weight)) +
            ((NumCruisers.Value + NumDreadnoughts.Value) * cruiser.Cruiser_Stats(ship.Ship_Stats.Weight))
        MaxShipCount = (NumCruisers.Value + NumDreadnoughts.Value) + 11
        lblCosts.Text = "Resource: " + CStr(ResourceCost) + "/" +
            CStr(P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Resource)) + Environment.NewLine +
            "Gas: " + CStr(GasCost) + "/" + CStr(P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Gas)) + Environment.NewLine +
            "Ships: " + CStr(ShipCount + Fleet.ShipCount) + "/ 16"
    End Sub

    Private Sub Accept_Click(sender As System.Object, e As System.EventArgs) Handles Accept.Click
        If Equals(Fleet, Nothing) = False Then
            If ResourceCost <= P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Resource) And
                GasCost <= P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Gas) Then
                If ShipCount + Fleet.ShipCount <= 16 Then

                    '-----Costs-----
                    P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Resource) =
                        P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Resource) - ResourceCost 'Resource
                    P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Gas) =
                        P.P.P.GameGalaxy.ProduceStores(Galaxy.Produce.Gas) - GasCost 'Gas
                    '---------------

                    '-----Fighters-----
                    For fighter As Integer = 0 To NumFighters.Value
                        If fighter > 0 Then
                            Fleet.Add_Ship(New playerFighter())
                        End If
                    Next
                    '------------------

                    '-----Bombers-----
                    For bomber As Integer = 0 To NumBombers.Value
                        If bomber > 0 Then
                            Fleet.Add_Ship(New playerBomber())
                        End If
                    Next
                    '-----------------

                    '-----Frigate-----
                    For Frigate As Integer = 0 To NumFrigates.Value
                        If Frigate > 0 Then
                            Fleet.Add_Ship(New playerFrigate())
                        End If
                    Next
                    '----------------

                    '-----Destroyer-----
                    For Destroyer As Integer = 0 To NumDestroyers.Value
                        If Destroyer > 0 Then
                            Fleet.Add_Ship(New playerDestroyer())
                        End If
                    Next
                    '-------------------

                    '-----Cruiser-----
                    For Cruiser As Integer = 0 To NumCruisers.Value
                        If Cruiser > 0 Then
                            Fleet.Add_Ship(New playerCruiser())
                        End If
                    Next
                    '-----------------

                    '-----Dreadnought-----
                    For Dreadnought As Integer = 0 To NumDreadnoughts.Value
                        If Dreadnought > 0 Then
                            Fleet.Add_Ship(New playerDreadnought())
                        End If
                    Next
                    '---------------------

                    P.P.P.Enabled = True
                    P.P.P.BringToFront()
                    Dim f As New MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, 0, 0, 0)
                    P.Clicked(f)
                    Close()
                End If
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        p.p.p.Enabled = True
        p.p.p.BringToFront()
        Close()
    End Sub

End Class