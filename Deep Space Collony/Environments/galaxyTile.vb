Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class galaxyTile
    Public Reference As BaseSpace
    Public Position As Point
    Public P As Galaxy
    <NonSerialized()>
    Public b As btnTile
    Public Enum ZoomLevels
        Sector
        System
    End Enum
    Public Shared Zoom As ZoomLevels = ZoomLevels.Sector

    Public Sub New(ByRef NParent As Galaxy, ByVal NPosition As Point)
        P = NParent
        Position = NPosition
        b = New btnTile(Me)
    End Sub

    Public Sub Zoom_Out()
        Zoom = ZoomLevels.Sector
        Update()
    End Sub

    Public Sub Update()
        b.FlatAppearance.BorderSize = 0
        b.BackColor = Color.Transparent
        b.Text = ""
        '-----Change the graphic-----
        If Reference IsNot Nothing Then
            Select Case Reference.Friendly
                Case Galaxy.Allegence.Friendly
                    b.FlatAppearance.BorderColor = Color.LimeGreen
                    b.FlatAppearance.BorderSize = 2
                Case Galaxy.Allegence.Enemy
                    b.FlatAppearance.BorderColor = Color.Red
                    b.FlatAppearance.BorderSize = 2
                Case Galaxy.Allegence.Neutral
                    b.FlatAppearance.BorderColor = Color.Yellow
                    b.FlatAppearance.BorderSize = 2
            End Select
            If Zoom = ZoomLevels.Sector Then
                Dim Sec As sector = Reference
                b.Text = CStr(Sec.Fleets.Length)
                If Sec.Highlighted = True Then 'Its highlighted
                    b.BackColor = Color.LightBlue
                End If
            End If
        End If
        '----------------------------
    End Sub

    Public Sub clicked(ByVal e As MouseEventArgs)
        If Reference IsNot Nothing Then
            Reference.Clicked(e)
        Else
            P.P.StatDisplay.Text = ""
            P.MakingWormhole = Nothing
            P.AddingShips = Nothing
            If P.FleetToMove IsNot Nothing Then
                For Each i As wormhole In P.FleetToMove.P.Connections
                    P.Sectors(i.Opening.X, i.Opening.Y).Highlighted = False
                    P.Sectors(i.Opening.X, i.Opening.Y).Graphic.Update()
                Next
                P.FleetToMove = Nothing
            End If
        End If
    End Sub

End Class
