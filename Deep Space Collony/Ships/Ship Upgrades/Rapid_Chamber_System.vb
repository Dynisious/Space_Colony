Public Class Rapid_Chamber_System
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Shots) = 1
        Name = "Rapid Chamber System"
        Description = "By adding something like the chambers of a giant revolver inside our Cruisers we can have them fire multiple times in quick succession." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
