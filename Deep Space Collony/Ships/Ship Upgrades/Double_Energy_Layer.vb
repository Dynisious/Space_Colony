Public Class Double_Energy_Layer
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.MaximumShields) = 10
        Name = "Double Energy Layers"
        Description = "The scientists have devised a shield generator that can have two layers of shielding. By attaching this to our bombers they will be better protected against enemy fire." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
