Public Class Pulsation_Shielding
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.MaximumShields) = 10
        Name = "Pulsation Shielding"
        Description = "The science team has devised a shield generator for our dreadnoughts were pulses of energy bounce back and forth between two solid shields vaporising anything that they come in contact with." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
