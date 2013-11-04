Public Class Scale_Plating
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Armour) = 10
        Name = "Scale Plating"
        Description = "By covering our Destroyers hulls with loosely held armoured plates we can better disperse the force of an impact without throwing everyone inside the ship off their feet." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
