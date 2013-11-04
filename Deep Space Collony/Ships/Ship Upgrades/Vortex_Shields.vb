Public Class Vortex_Shields
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.MaximumShields) = 10
        Name = "Vortex Shields"
        Description = "The science team did an experiment with a shield generator that made the energy spin around the object like a vortex. This would actually deflect incoming projectiles increasing the effectiveness of the shields." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
