Public Class Streaker_Missiles
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Damage) = 10
        Name = "Streaker Missiles"
        Description = "By attaching pods of short range missiles to the exterior of our fighters they can hit a target for more damage." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
