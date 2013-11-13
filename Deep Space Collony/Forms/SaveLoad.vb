Imports System.Runtime.Serialization.Formatters.Binary

Public Class SaveLoad
    Dim WithEvents tick As New Timer With {.Enabled = True, .Interval = 100}
    Public P As Screen
    Public Enum FileModes
        Saving
        Loading
    End Enum
    Public Action As FileModes

    Public Sub New(ByVal NAction As FileModes, Optional ByRef NParent As Screen = Nothing)
        InitializeComponent()
        P = NParent
        Action = NAction
        If IO.Directory.Exists("..\..\SpaceColonySaves") = False Then 'The path doesn't exist
            IO.Directory.CreateDirectory("..\..\SpaceColonySaves")
        End If
        If NAction = FileModes.Saving Then
            btnSaveLoad.Text = "Save"
            If P.GameGalaxy.WorldTimer.Enabled = True Then 'Pause the game
                P.Pause_Click(Me, New EventArgs)
                P.Enabled = False
            End If
        ElseIf NAction = FileModes.Loading Then
            btnSaveLoad.Text = "Load"
            MainMenu.Enabled = False
        End If
        Visible = True
        BringToFront()
    End Sub

    Private Sub lblSave1_Click(sender As System.Object, e As System.EventArgs) Handles lblSave1.Click
        lblName.Text = lblSave1.Text
    End Sub

    Private Sub lblSave2_Click(sender As System.Object, e As System.EventArgs) Handles lblSave2.Click
        lblName.Text = lblSave2.Text
    End Sub

    Private Sub lblSave3_Click(sender As System.Object, e As System.EventArgs) Handles lblSave3.Click
        lblName.Text = lblSave3.Text
    End Sub

    Private Sub btnSaveLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveLoad.Click
        If lblName.Text <> "" Then
            If Action = FileModes.Saving Then
                Using fs As New IO.FileStream("..\..\SpaceColonySaves\" + lblName.Text + ".save", IO.FileMode.Create)
                    Dim bf As BinaryFormatter = New BinaryFormatter
                    bf.Serialize(fs, P.GameGalaxy)
                    fs.Close()
                End Using
                P.Enabled = True
                P.Pause_Click(Me, New EventArgs)
                P.BringToFront()
            ElseIf Action = FileModes.Loading Then
                Using fs As New IO.FileStream("..\..\SpaceColonySaves\" + lblName.Text + ".save", IO.FileMode.OpenOrCreate)
                    If fs.Length <> 0 Then 'Its not an empty file
                        Dim bf As BinaryFormatter = New BinaryFormatter
                        P = New Screen(False)
                        P.GameGalaxy = bf.Deserialize(fs)
                        P.GameGalaxy.LoadGame(P)
                        fs.Close()
                    Else
                        MainMenu.Enabled = True
                        MainMenu.BringToFront()
                    End If
                End Using
            End If
            Close()
        End If
    End Sub

    Private Sub tick_tick() Handles tick.Tick
        BringToFront()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If P IsNot Nothing Then
            P.Pause_Click(Me, New EventArgs)
            P.Enabled = True
            P.BringToFront()
        End If
        Close()
    End Sub
End Class