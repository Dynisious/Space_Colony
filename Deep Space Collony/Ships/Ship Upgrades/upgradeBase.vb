Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public MustInherit Class upgradeBase
    Public TypeOfShip As ship.Ship_Types
    Public Name As String
    Public Description As String
    Public Stats As New Dictionary(Of ship.Ship_Stats, Integer)
    Public Enum ShipUpgrades
        '-----Fighter-----
        Streaker_Missiles 'Damage
        Combat_Thrusters 'Armour
        Trident_Generator 'Shields
        Guided_Projectiles 'Accuracy
        Rotary_Cannon 'Shots
        '-----------------
        '-----Bomber-----
        Nuclear_Explosives 'Damage
        Crystaline_Plates 'Armour
        Double_Energy_Layer 'Shields
        Bomb_AI 'Accuracy
        Carpet_Bomb 'Shots
        '----------------
        '-----Frigate-----
        Advanced_Rail_Gun 'Damage
        Boi_Metal 'Armour
        Vortex_Shields 'Shields
        Three_Point_Targeting 'Accuracy
        Segmented_Projectiles 'Shots
        '-----------------
        '-----Destroyer-----
        Scatter_Shot 'Damage
        Scale_Plating 'Armour
        Pulse_Shields 'Shields
        Turbine_Firing_Machanism 'Accuracy
        Repeater_Cannons 'Shots
        '-------------------
        '-----Cruiser-----
        Volley_Rockets 'Damage
        Magnetic_Armour 'Armour
        Counter_Spin_Genorators 'Shields
        Advanced_Sighting_Computer 'Accuracy
        Rapid_Chamber_System 'Shots
        '-----------------
        '-----Dreadnought-----
        Advanced_Plasma_Cannons 'Damage
        Single_Case_Construction 'Armour
        Pulsation_Shielding 'Shields
        Shaped_Charges 'Accuracy
        Plasma_Injection 'Shots
        '---------------------
        Max
    End Enum
    Public Shared ReadOnly ListOfUpgrades As New Dictionary(Of ShipUpgrades, upgradeBase)
    Public Costs As New Dictionary(Of Galaxy.Produce, Integer)

    Public Sub Upgrade()
        Select Case TypeOfShip
            Case ship.Ship_Types.Fighter
                For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In playerFighter.PFighter_Stats
                    playerFighter.PFighter_Stats(i.Key) = playerFighter.PFighter_Stats(i.Key) + Stats(i.Key)
                Next

            Case ship.Ship_Types.Bomber
                For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In playerBomber.PBomber_Stats
                    playerBomber.PBomber_Stats(i.Key) = playerBomber.PBomber_Stats(i.Key) + Stats(i.Key)
                Next

            Case ship.Ship_Types.Frigate
                For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In playerFrigate.PFrigate_Stats
                    playerFrigate.PFrigate_Stats(i.Key) = playerFrigate.PFrigate_Stats(i.Key) + Stats(i.Key)
                Next

            Case ship.Ship_Types.Destroyer
                For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In playerDestroyer.PDestroyer_Stats
                    playerDestroyer.PDestroyer_Stats(i.Key) = playerDestroyer.PDestroyer_Stats(i.Key) + Stats(i.Key)
                Next

            Case ship.Ship_Types.Cruiser
                For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In playerCruiser.PCruiser_Stats
                    playerCruiser.PCruiser_Stats(i.Key) = playerCruiser.PCruiser_Stats(i.Key) + Stats(i.Key)
                Next

            Case ship.Ship_Types.Dreadnought
                For Each i As KeyValuePair(Of ship.Ship_Stats, Integer) In playerDreadnought.PDreadnought_Stats
                    playerDreadnought.PDreadnought_Stats(i.Key) = playerDreadnought.PDreadnought_Stats(i.Key) + Stats(i.Key)
                Next
        End Select
    End Sub
End Class
