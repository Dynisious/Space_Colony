Public Class Advanced_Plasma_Cannons
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Damage) = 10
        Name = "Advanced Plasma Cannons"
        Description = "By changing the placement of the accelerators inside the plasma cannons of our dreadnoughts we can have them hit even harder than before." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
