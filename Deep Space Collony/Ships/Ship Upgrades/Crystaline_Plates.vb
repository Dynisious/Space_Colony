Public Class Crystaline_Plates
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Armour) = 10
        Name = "Crystaline Plates"
        Description = "We have discovered a new way of armouring our ships with a crystalline alloy much like diamond we can improve the armour on our bombers without adding extra weight." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
