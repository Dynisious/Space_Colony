Public Class Bio_Metal
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Armour) = 10
        Name = "Bio Metal"
        Description = "The science team has created a small biomechanical alloy that can shape itself and by adding this too our frigates they can reshape misshapen armour increasing their defence." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
