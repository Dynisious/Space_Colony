Public Class Volley_Rockets
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Damage) = 10
        TypeOfShip = ship.Ship_Types.Cruiser
        Name = "Volley Rockets"
        Description = "The scientists have discovered a way to integrate rocket targeting into the targeting algorithms so you can fire a volley of rockets along with the Cruisers main cannons." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
