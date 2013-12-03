Public Class MakingWormholes
    Private WithEvents tick As New Timer With {.Enabled = True, .Interval = 100}
    Public P As sector 'The sector being interacted with
    Public btns(-1) As btnHole 'The buttons
    Private Shared ReadOnly Alpha As New Dictionary(Of Integer, String) From {
        {0, "A"}, {1, "B"}, {2, "C"}, {3, "D"}, {4, "E"}, {5, "F"}, {6, "G"},
        {7, "H"}, {8, "I"}, {9, "J"}, {10, "K"}, {11, "L"}, {12, "M"}, {13, "N"},
        {14, "O"}, {15, "P"}, {16, "Q"}, {17, "R"}, {18, "S"}, {19, "T"}, {20, "U"},
        {21, "V"}, {22, "W"}, {23, "X"}, {24, "Y"}, {25, "Z"}, {26, "AA"}
    }

    Public Sub New(ByRef NParent As sector)
        InitializeComponent()
        P = NParent
        Visible = True
        Dim Index As Integer

        For X As Integer = P.Position.X - 4 To P.Position.X + 4
            If X >= 0 And X <= 26 Then
                For Y As Integer = P.Position.Y - 4 To P.Position.Y + 4
                    If Y >= 0 And Y <= 9 Then
                        If P.P.Sectors(X, Y) IsNot Nothing Then 'Theres a sector
                            Dim GoOn As Boolean = True
                            For Each i As wormhole In P.Connections
                                If New Point(X, Y) = i.Opening And i.Artificial = True Then 'Theres already a wormhole being paid for
                                    ReDim Preserve btns(btns.Length)
                                    btns(UBound(btns)) = New btnHole(Me, Index, i)
                                    Index = Index + 1
                                    GoOn = False
                                    Exit For
                                ElseIf New Point(X, Y) = i.Opening And i.Artificial = False Then 'Its a natural wormhole
                                    GoOn = False
                                    Exit For
                                End If
                            Next
                            If GoOn = True Then 'Add a new wormhole
                                ReDim Preserve btns(btns.Length)
                                btns(UBound(btns)) = New btnHole(Me, Index, New artificialWormhole(P, New Point(X, Y), False, Galaxy.Allegence.Friendly))
                                Index = Index + 1
                            End If
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Public Class btnHole
        Inherits Button
        Private Wormhole As artificialWormhole
        Private P As MakingWormholes
        Private Info As String

        Public Sub New(ByRef NParent As MakingWormholes, ByVal index As Integer, ByRef NWormhole As wormhole)
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
                If Wormhole.Artificial = True Then 'Remove wormhole
                    Wormhole.Artificial = False
                    Wormhole.Remove_Wormhole()
                Else 'Add wormhole
                    Wormhole.Artificial = True
                    Wormhole.Add_Wormhole()
                End If
            End If

            '-----Change info-----
            Info = "Exit: (" + Alpha(Wormhole.Opening.X) + "," + CStr(Wormhole.Opening.Y + 1) + ")" + Environment.NewLine +
                "Closed: "
            If Wormhole.Artificial = True Then
                Info = Info + "Open"
            Else
                Info = Info + "Closed"
            End If
            Info = Info + Environment.NewLine + "Warning: To keep this wormhole Open it will take Gas 300/min!"
            '---------------------

            P.Discription.Text = Info
        End Sub

    End Class

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        P.P.P.Enabled = True
        P.P.P.BringToFront()
        Close()
    End Sub

    Private Sub tick_tick() Handles tick.Tick
        BringToFront()
    End Sub

End Class