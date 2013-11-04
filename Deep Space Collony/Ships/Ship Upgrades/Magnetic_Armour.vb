Public Class Magnetic_Armour
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Armour) = 10
        Name = "Magnetic Armour"
        Description = "The science team has made a break through concerning our armour; they’ve discovered that by running power through the plates we can slow slugs and disperse plasma before it hits. Sadly only cruisers have the power supply to utilise this." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
