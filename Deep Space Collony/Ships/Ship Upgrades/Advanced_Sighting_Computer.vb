Public Class Advanced_Sighting_Computer
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Accuracy) = 10
        Name = "Advanced Sighting Computer"
        Description = "The scientists have found a way to have multiple of our cruisers targeting computers run in parallel meaning the ship becomes more accurate." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
