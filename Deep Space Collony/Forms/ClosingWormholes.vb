Public Class ClosingWormholes
    Public Wormholes() As wormhole 'The fleets being interacted with
    Public btns(0) As btnHole 'The buttons
    Private Shared ReadOnly Alpha As New Dictionary(Of Integer, String) From {
        {0, "A"}, {1, "B"}, {2, "C"}, {3, "D"}, {4, "E"}, {5, "F"}, {6, "G"},
        {7, "H"}, {8, "I"}, {9, "J"}, {10, "K"}, {11, "L"}, {12, "M"}, {13, "N"},
        {14, "O"}, {15, "P"}, {16, "Q"}, {17, "R"}, {18, "S"}, {19, "T"}, {20, "U"},
        {21, "V"}, {22, "W"}, {23, "X"}, {24, "Y"}, {25, "Z"}, {26, "AA"}
    }

    Public Sub New(ByRef NWormholes() As wormhole, ByVal SecPos As Point)
        InitializeComponent()
        CreateControl()
        Visible = True
        Wormholes = NWormholes

        For Each i As wormhole In Wormholes
            If i.Opening <> SecPos Then 'Its not the same as the sector
                If Equals(btns(0), Nothing) = False Then 'Its got buttons
                    ReDim Preserve btns(UBound(btns) + 1) 'Add a new space
                End If
                btns(UBound(btns)) = New btnHole(Me, UBound(btns), i) 'Initialise the button
            End If
        Next
    End Sub

    Public Class btnHole
        Inherits Button
        Private Wormhole As wormhole
        Private P As ClosingWormholes
        Private Info As String

        Public Sub New(ByRef NParent As ClosingWormholes, ByVal index As Integer, ByRef NWormhole As wormhole)
            P = NParent
            FlatStyle = Windows.Forms.FlatStyle.Flat
            Size = New Point(75, 25)
            Location = New Point(10, (index * 35))
            Wormhole = NWormhole
            Text = "Exit(" + Alpha(Wormhole.Opening.X) + "," + CStr(Wormhole.Opening.Y + 1) + ")"
            P.Display.Controls.Add(Me) 'Add to the screen
        End Sub

        Public Sub Mouse_Down(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 2 Then
                If Wormhole.Closed = True Then
                    Wormhole.Closed = False
                Else
                    Wormhole.Closed = True
                End If
            End If

            '-----Change info-----
            Info = "Exit: (" + Alpha(Wormhole.Opening.X) + "," + CStr(Wormhole.Opening.Y + 1) + ")" + Environment.NewLine +
                "Closed: "
            If Wormhole.Closed = True Then
                Info = Info + "Closed"
            Else
                Info = Info + "Open"
            End If
            Info = Info + Environment.NewLine + "Warning: To keep this wormhole closed it will take resource 6/sec"
            '---------------------

            P.Discription.Text = Info
        End Sub

    End Class

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Screen.Enabled = True
        Screen.BringToFront()
        Close()
    End Sub

End Class