Public Class Single_Case_Construction
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Armour) = 10
        Name = "Single Case Construction"
        Description = "The science team has found that by constructing dreadnoughts by layering liquid metal that the shock of an impact can be better dispersed decreasing damage to the hull." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
