Public Class RandomEvents

    Public Shared Sub Black_Hole(ByRef NSec As sector)
        For X As Integer = NSec.Position.X - 2 To NSec.Position.X + 2
            If X >= 1 And X <= 25 Then
                For Y As Integer = NSec.Position.Y - 2 To NSec.Position.Y + 2
                    If Y >= 1 And Y <= 8 Then
                        If NSec.P.Sectors(X, Y) IsNot Nothing Then
                            For Each e As starSystem In NSec.P.Sectors(X, Y).Systems 'every system in the sector
                                If Equals(e, Nothing) = False Then
                                    e.Friendly = Galaxy.Allegence.Neutral
                                End If
                            Next
                            If NSec.P.Sectors(X, Y).Fleets.Length <> 0 Then 'Theres fleets
                                For Each e As fleet In NSec.P.Sectors(X, Y).Fleets 'every fleet in the sector
                                    For Each f As ship In e.Ships
                                        e.P = Nothing
                                    Next
                                    ReDim e.Ships(-1)
                                Next
                                ReDim NSec.P.Sectors(X, Y).Fleets(-1)
                            End If
                            For Each e As wormhole In NSec.P.Sectors(X, Y).Connections
                                e.Closed = False
                            Next
                            NSec.P.Sectors(X, Y).Friendly = Galaxy.Allegence.Neutral 'Make the sector neutral
                        End If
                    End If
                Next
            End If
        Next
    End Sub

End Class
