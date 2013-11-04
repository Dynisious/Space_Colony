Public Class Shaped_Charges
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Accuracy) = 10
        Name = "Shaped Chargers"
        Description = "By using magnetic pulses the science team believes they can shaped the plasma fired by our dreadnoughts allowing them to hit their targets for greater damage." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
