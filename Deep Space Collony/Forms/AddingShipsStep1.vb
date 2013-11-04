Public Class AddingShipsStep1
    Public P As sector
    Public Fleets() As fleet 'The fleets being interacted with
    Public btns(0) As btnFleet 'The buttons

    Public Sub New(ByRef NFleets() As fleet, ByRef NParent As sector)
        InitializeComponent()
        CreateControl()
        Visible = True
        Fleets = NFleets
        P = NParent

        If Fleets.Length <> 0 Then 'If theres fleets
            For Each i As fleet In Fleets
                If i.Friendly = Galaxy.Allegence.Friendly Then 'Its player owned
                    If Equals(UBound(btns), Nothing) = False Then 'Its got buttons
                        ReDim Preserve btns(UBound(btns) + 1) 'Add a new space
                    End If
                    btns(UBound(btns)) = New btnFleet(Me, UBound(btns) - 1, i) 'Initialise the button
                End If
            Next
        End If
    End Sub

    Public Class btnFleet
        Inherits Button
        Private Fleet As fleet
        Private P As AddingShipsStep1
        Private Info As String

        Public Sub New(ByRef NParent As AddingShipsStep1, ByVal index As Integer, ByRef NFleet As fleet)
            P = NParent
            BackColor = Color.White
            FlatStyle = Windows.Forms.FlatStyle.Flat
            Size = New Point(75, 25)
            Location = New Point(10, (index * 35))
            Fleet = NFleet
            Text = "Fleet " + CStr(index + 1)
            P.Display.Controls.Add(Me) 'Add to the screen
            Dim count(ship.Ship_Types.Max - 1) As Integer 'the number of each type of ship in the fleet
            For Each i As ship In Fleet.Ships
                If Equals(i, Nothing) = False Then
                    count(i.Type) = count(i.Type) + 1 'Add to the count
                End If
            Next
            Info = "Fighters: " + CStr(count(ship.Ship_Types.Fighter)) + Environment.NewLine +
                "Bombers: " + CStr(count(ship.Ship_Types.Bomber)) + Environment.NewLine +
                "Frigates: " + CStr(count(ship.Ship_Types.Frigate)) + Environment.NewLine +
                "Destroyers: " + CStr(count(ship.Ship_Types.Destroyer)) + Environment.NewLine +
                "Cruisers: " + CStr(count(ship.Ship_Types.Cruiser)) + Environment.NewLine +
                "Dreadnoughts: " + CStr(count(ship.Ship_Types.Dreadnought))
        End Sub

        Public Sub Mouse_Down(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 2 And Fleet.ShipCount <> 15 Then
                Dim Temp As New AddingShipsStep2(Fleet, P.P)
                P.Close()
            End If

            P.Discription.Text = Info
        End Sub

    End Class

    Private Sub NewFleet_Click(sender As System.Object, e As MouseEventArgs) Handles NewFleet.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 2 Then
            If P.P.ProduceStores(Galaxy.Produce.Resource) >=
                fighter.Fighter_Costs(Galaxy.Produce.Resource) Then 'There's enough resource
                P.P.ProduceStores(Galaxy.Produce.Resource) =
                    P.P.ProduceStores(Galaxy.Produce.Resource) - fighter.Fighter_Costs(Galaxy.Produce.Resource)
                P.Add_Fleet(New fleet(P, New playerFighter(), P.Position, Galaxy.Allegence.Friendly))
                Dim Temp As New AddingShipsStep2(P.Fleets(UBound(P.Fleets)), P)
                Close()
            End If
        Else
            Discription.Text =
                "This Makes a new fleet in the selected sector and it starts with one fighter costing:" +
                Environment.NewLine + "Resource: " + CStr(fighter.Fighter_Costs(Galaxy.Produce.Resource))
        End If
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        P.P.P.Enabled = True
        P.P.P.BringToFront()
        Close()
    End Sub
End Class