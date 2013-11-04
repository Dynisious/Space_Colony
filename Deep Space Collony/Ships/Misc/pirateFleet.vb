Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class PirateFleet
    Inherits fleet

    Public Sub New(ByRef NParent As sector, ByRef TickCount As Integer, ByVal NPosition As Point)
        MyBase.New(NParent, New pirateFighter, NPosition, Galaxy.Allegence.Enemy)
        P.P.PirateCount = P.P.PirateCount + 1 'Add me to the count

        Dim NewShips As Integer = (Int(TickCount / 6000) + 1)
        If NewShips > 9 Then
            NewShips = 9
        End If
        For i As Integer = 0 To NewShips
            If i > 19 Then
                i = 19 'Make sure their aren't too many ships
            End If
            Dim Type As Integer
            Dim Temp As Integer = TickCount / 18000
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

        If TickCount = 0 Then
            Dim GoOn As Boolean = True
            For Each i As starSystem In P.Systems
                If i.Empty = False Then
                    If i.Friendly = Galaxy.Allegence.Neutral Then
                        GoOn = False
                    End If
                End If
            Next
            If P.Battle IsNot Nothing Then
                GoOn = False
            End If

            If GoOn = True Then 'Move to a new sector
                Dim MakeJump As Boolean = False
                Do Until MakeJump = True
                    Dim EntryHole As wormhole = P.Connections(Int(UBound(P.Connections) * Rnd()))  'The wormhole entrance
                    Dim ExitHole As wormhole 'The wormhole exit
                    Dim NewSec As sector = P.P.Sectors(EntryHole.Opening.X, EntryHole.Opening.Y) 'The new sector
                    For Each i As wormhole In NewSec.Connections
                        If i.Opening = P.Position Then
                            ExitHole = i
                        End If
                    Next
                    If Equals(ExitHole, Nothing) = False Then
                        If ExitHole.Closed = False Then 'The wormhole is open
                            If NewSec.Empty = False Then
                                MakeJump = True
                                P.Remove_Fleet(Me) 'Remove the old reference
                                ExitHole.P.Add_Fleet(Me) 'Add the new reference
                            End If
                        End If
                    End If
                Loop
            ElseIf GoOn = False And Int(4 * Rnd()) = 0 Then 'Colonise
                Dim sys As starSystem
                For Each i As starSystem In P.Systems
                    If i.Empty = False Then
                        If i.Friendly = Galaxy.Allegence.Neutral Then
                            sys = i
                        End If
                    End If
                Next
                If Equals(sys, Nothing) = False Then
                    sys.Friendly = Galaxy.Allegence.Enemy
                End If
            End If
        End If
    End Sub

    Public Overrides Sub Kill()
        P.P.PirateCount = P.P.PirateCount - 1
        P.Remove_Fleet(Me)
        P = Nothing
    End Sub

End Class
