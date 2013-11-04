Public Class Carpet_Bomb
    Inherits upgradeBase

    Public Sub New()
        Stats(ship.Ship_Stats.Shots) = 1
        Name = "Carpet Bomb"
        Description = "The engineers have developed a way to put the same firepower as one of our bombers bombs into multiple smaller bombs increasing the area that the bomb impacts." + Environment.NewLine +
            "Damage: +" + CStr(Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Armour: +" + CStr(Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "Shields: +" + CStr(Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: +" + CStr(Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Shots: +" + CStr(Stats(ship.Ship_Stats.Shots))
    End Sub

End Class
