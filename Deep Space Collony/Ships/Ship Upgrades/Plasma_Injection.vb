Public Class Plasma_Injection
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Shots) = 1
        Name = "Plasma Injection"
        Description = "With this new mechanism the plasma fired by the dreadnoughts gets injected in much faster than before so that they can fire faster." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
