Public Class SelectingFleets
    Public P As sector
    Public Fleets() As fleet 'The fleets being interacted with
    Public btns(0) As btnFleet 'The buttons

    Public Sub New(ByRef NParent As sector, ByRef NFleets() As fleet)
        InitializeComponent()
        P = NParent
        CreateControl()
        Visible = True
        Fleets = NFleets

        For Each i As fleet In Fleets
            If i.Friendly = Galaxy.Allegence.Friendly Then 'Its player owned
                If Equals(UBound(btns), Nothing) = False Then 'Its got buttons
                    ReDim Preserve btns(UBound(btns) + 1) 'Add a new space
                End If
                btns(UBound(btns)) = New btnFleet(Me, UBound(btns) - 1, i) 'Initialise the button
            End If
        Next
    End Sub

    Public Class btnFleet
        Inherits Button
        Private Fleet As fleet
        Private P As SelectingFleets
        Private Info As String

        Public Sub New(ByRef NParent As SelectingFleets, ByVal index As Integer, ByRef NFleet As fleet)
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
            If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 2 Then
                If Equals(Fleet.P, Nothing) = False Then
                    P.P.P.FleetToMove = Fleet
                    For Each i As wormhole In Fleet.P.Connections
                        Dim f As wormhole
                        For Each FSelect As wormhole In i.P.P.Sectors(i.Opening.X, i.Opening.Y).Connections
                            If i.P.Position = FSelect.Opening Then
                                f = FSelect
                            End If
                        Next
                        If f.Closed = False Then
                            i.P.P.Sectors(i.Opening.X, i.Opening.Y).Highlighted = True
                            i.P.P.Sectors(i.Opening.X, i.Opening.Y).Graphic.Update()
                        End If
                    Next
                End If
                P.P.P.P.Pause_Click(Me, New EventArgs)
                P.P.P.P.Enabled = True
                P.P.P.P.BringToFront()
                P.Close()
            End If

            P.Discription.Text = Info
        End Sub

    End Class

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        P.P.P.Pause_Click(Me, New EventArgs)
        P.P.P.Enabled = True
        P.P.P.BringToFront()
        For Each i As wormhole In P.Connections
            P.P.Sectors(i.Opening.X, i.Opening.Y).Highlighted = False
        Next
        Close()
    End Sub
End Class