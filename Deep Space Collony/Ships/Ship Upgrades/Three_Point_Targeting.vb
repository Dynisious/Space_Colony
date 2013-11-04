Public Class Three_Point_Targeting
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Accuracy) = 10
        Name = "Three Point Targeting"
        Description = "The engineers have developed a new targeting algorithm for our frigates. By triangulating surrounding ships the frigate can better predict where their target will be and will hit their target more often." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
