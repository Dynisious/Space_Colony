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
    Public Zoom As ZoomLevels = ZoomLevels.Sector

    Public Sub New(ByRef NParent As Galaxy, ByRef NReference As sector, ByVal NPosition As Point)
        P = NParent
        Reference = NReference
        Reference.graphic = Me
        Position = NPosition
        b = New btnTile(Me)
        Update()
    End Sub

    Public Sub Zoom_Out()
        Reference = P.Sectors(Position.X, Position.Y)
        Zoom = ZoomLevels.Sector
        Update()
    End Sub

    Public Sub Update()
        b.FlatAppearance.BorderColor = Color.LightSlateGray
        b.BackColor = Color.Transparent
        '-----Change the graphic-----
        If Reference.Empty = False Then 'Its filled
            Select Case Reference.Friendly
                Case Galaxy.Allegence.Friendly
                    b.FlatAppearance.BorderColor = Color.LimeGreen
                    b.FlatAppearance.BorderSize = 2
                Case Galaxy.Allegence.Enemy
                    b.FlatAppearance.BorderColor = Color.Red
                    b.FlatAppearance.BorderSize = 2
                Case Galaxy.Allegence.Neutral
                    b.FlatAppearance.BorderColor = Color.Yellow
            End Select
            If Zoom = ZoomLevels.Sector Then
                Dim Sec As sector = Reference
                b.Text = CStr(Sec.Fleets.Length)
            End If
        End If
        If Zoom = ZoomLevels.System Then
            b.Text = ""
        End If

        If Reference.Highlighted = True Then 'Its highlighted
            b.BackColor = Color.LightBlue
        End If
        '----------------------------
    End Sub

    Public Sub Clicked(e As MouseEventArgs)
        Reference.Clicked(e)
    End Sub

End Class
