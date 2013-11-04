Public Class Turbine_Firing_Mechanism
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Accuracy) = 10
        TypeOfShip = ship.Ship_Types.Destroyer
        Name = "Turbine Firing Mechanism"
        Description = "This turbine firing mechanism can be integrated into our Destroyers to increase their accuracy. By increasing the spin on the projectiles we can use more accurate rounds" + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
