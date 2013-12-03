Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class PirateFleet
    Inherits fleet
    Public Shared LongJumps As Integer

    Public Sub New(ByRef NParent As sector, ByRef TickCount As Integer)
        MyBase.New(NParent, New pirateFighter, Galaxy.Allegence.Enemy)
        P.P.PirateCount = P.P.PirateCount + 1 'Add me to the count

        Dim NewShips As Integer = (Int(TickCount / 6000) + 1)
        If NewShips > 9 Then
            NewShips = 9
        End If
        For i As Integer = 0 To NewShips
            Dim Type As Integer
            Dim Temp As Integer = TickCount / 12000
            If Temp < 150 And Temp > 110 Then
                Type = Int((Temp * Rnd()) + 1)
            ElseIf Temp < 110 Then
                Type = Int(150 * Rnd())
            ElseIf Temp > 220 Then
                Type = Int((220 * Rnd()) + 1)
            End If
            If Type > 210 Then
                Add_Ship(New pirateCruiser)
            ElseIf Type > 150 Then
                Add_Ship(New pirateDestroyer)
            ElseIf Type > 110 Then
                Add_Ship(New pirateFrigate)
            ElseIf Type > 60 Then
                Add_Ship(New pirateBomber)
            Else
                Add_Ship(New pirateFighter)
            End If
        Next
    End Sub

    Public Overrides Sub Update(ByVal InBattle As Boolean)
        MyBase.Update(InBattle)

        If TickCount = 0 And InBattle = False Then
            '-----Collonise-----
            For Each i As starSystem In P.Systems 'Check systems
                If i IsNot Nothing Then
                    If i.Friendly <> Galaxy.Allegence.Enemy Then 'Check its allegence
                        i.Friendly = Galaxy.Allegence.Enemy 'Collonise
                        Exit Sub
                    End If
                End If
            Next
            '-------------------
            If Int(3 * Rnd()) = 0 Then
                '-----Jump-----
                For Each i As wormhole In P.Connections 'Check wormholes
                    If P.P.Sectors(i.Opening.X, i.Opening.Y).Friendly = Galaxy.Allegence.Neutral Then 'Theres an uncolonised sector
                        Normal_Jump() 'Make jump
                        Exit Sub
                    End If
                Next
                If Int(10 * Rnd()) = 0 Then
                    Extended_Jump()
                Else
                    Normal_Jump()
                End If
                '--------------
            End If
        End If
    End Sub

    Private Sub Normal_Jump()
        Dim ExitPoint As Point = P.Connections(Int(P.Connections.Length * Rnd())).Opening
        Dim NewSec As sector = P.P.Sectors(ExitPoint.X, ExitPoint.Y)
        P.Remove_Fleet(Me)
        NewSec.Add_Fleet(Me)
    End Sub

    Private Sub Extended_Jump()
        If LongJumps > 0 Then
            Dim Secs(-1) As sector

            For X As Integer = P.Position.X - 4 To P.Position.X + 4
                If X >= 0 And X <= 26 Then
                    For Y As Integer = P.Position.Y - 4 To P.Position.Y + 4
                        If Y >= 0 And Y <= 9 Then
                            If P.P.Sectors(X, Y) IsNot Nothing Then
                                If P.P.Sectors(X, Y).Friendly <> Galaxy.Allegence.Enemy Then
                                    ReDim Preserve Secs(Secs.Length)
                                    Secs(UBound(Secs)) = P.P.Sectors(X, Y)
                                End If
                            End If
                        End If
                    Next
                End If
            Next

            If Secs.Length <> 0 Then
                Dim ExitSec As sector = Secs(Int(Secs.Length * Rnd()))
                ReDim Preserve P.Connections(P.Connections.Length)
                P.Connections(UBound(P.Connections)) = New artificialWormhole(P, ExitSec.Position, True, Galaxy.Allegence.Enemy)
                P.Remove_Fleet(Me)
                ExitSec.Add_Fleet(Me)
            Else
                Normal_Jump()
            End If
        Else
            Normal_Jump()
        End If
    End Sub

    Public Overrides Sub Kill()
        MyBase.Kill()
        P.P.PirateCount = P.P.PirateCount - 1
    End Sub

End Class
