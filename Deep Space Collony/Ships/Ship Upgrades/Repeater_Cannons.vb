Public Class Repeater_Cannons
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Shots) = 1
        Name = "Repeater Cannons"
        Description = "The engineers have devised a mechanism that allows our Destroyers to quickly reload and fire a second shot before anyone can think." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
