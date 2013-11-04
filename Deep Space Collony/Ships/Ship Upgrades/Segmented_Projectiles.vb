Public Class Segmented_Projectiles
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Shots) = 1
        Name = "Segmented Projectiles"
        Description = "The engineers have devised a different way of making the shots fired by the frigates rail guns so that they can fire multiple simultaneously." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
