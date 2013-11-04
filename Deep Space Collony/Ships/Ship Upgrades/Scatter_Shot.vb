Public Class Scatter_Shot
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Damage) = 10
        Name = "Scatter Shot"
        Description = "By casting the slugs fired by our Destroyers with fault lines it will shatter on impact acting like a giant shot gun lacerating the enemies’ hull." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
