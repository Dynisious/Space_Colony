Public Class Guided_Projectiles
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Accuracy) = 10
        Name = "Guided Projectiles"
        Description = "Because the fighters engage in such close dogfights we can effectively guide projectiles as they travel to their target so all the pilot has to do is keep pointing at the enemy and the round will hit." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
