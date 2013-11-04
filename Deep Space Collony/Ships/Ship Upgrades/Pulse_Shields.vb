Public Class Pulse_Shields
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.MaximumShields) = 10
        Name = "Pulse Shields"
        Description = "The science team thinks they can attach sensors all over our destroyers so that instead of having a weaker shield up all the time a destroyer can just send a strong pulse of shields to counter incoming projectiles." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
