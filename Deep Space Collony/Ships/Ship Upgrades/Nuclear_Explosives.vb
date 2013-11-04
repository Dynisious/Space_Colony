Public Class Nuclear_Explosives
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Damage) = 10
        Name = "Nuclear Explosives"
        Description = "By outfitting our bombers with the time honoured nuke they can be better at vaporising ships than ever before." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
