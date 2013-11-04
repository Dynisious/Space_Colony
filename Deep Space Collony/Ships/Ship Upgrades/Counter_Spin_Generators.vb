Public Class Counter_Spin_Generators
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.MaximumShields) = 10
        Name = "Counter Spin Generators"
        Description = "The engineers accidentally put one of our cruisers the generators in backwards but it turns out this increases the power meaning we can add more power to shields if we do this in all cruisers." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
