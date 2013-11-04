Public Class Encylopedia

    Public Sub New()
        InitializeComponent()
        Visible = True
        lblShips.Text = Ships_String()
        lblEnvironments.Text = Environments_String()
        lblFactions.Text = Factions_String()
    End Sub

    Private Function Ships_String()
        Dim Text As String =
            "Legend:" + Environment.NewLine +
            "Armour: The ships % chance to not take damage when hit (Only in effect when Shields are depleted)." + Environment.NewLine +
            "MaximumShields: Shields take hits without damaging the health. Shields recharge at a rate of 1 point/sec so don't rush into a new battle too quickly" + Environment.NewLine +
            "Accuracy: The ships % chance to hit their target each shot." + Environment.NewLine +
            "Damage: The ships damage per successful hit." + Environment.NewLine +
            "Shots: How many times a ship fires per attack." + Environment.NewLine +
            "Weight: How much space it takes up in a fleet." + Environment.NewLine +
            "Hanger: How many drones the ship will deploy at the start of a battle." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Fleets:" + Environment.NewLine +
            "Fleets are groups of ships that move and fight together. Fleets have a cap on how many weight points they can hold so be aware when adding ships too a fleet" + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Ships:" + Environment.NewLine +
            "Ships are the space craft that you lead into battle. All Ships start with 100 health but when the shields are depleted the health starts to take hits. Health regenerates half as quickly as shields do so take a pause before sending your fleets into the next battle or even your most powerful fleets will be worn down." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Fighter:" + Environment.NewLine +
            "Armour: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(fighter.Fighter_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Costs: " + CStr(fighter.Fighter_Costs(Galaxy.Produce.Resource)) + " Resource and " + CStr(fighter.Fighter_Costs(Galaxy.Produce.Gas)) + " Gas" + Environment.NewLine +
            "Discription: Fighters are small ships with poor shields, armour, accuracy and damage but because of their rate of fire they can do good damage to the enemy. These ships are cheap and light so you can have large fleets of them meaning their shields can recharge before they are targeted again and in a group they be a formidable force." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Bomber:" + Environment.NewLine +
            "Armour: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(bomber.Bomber_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Costs: " + CStr(bomber.Bomber_Costs(Galaxy.Produce.Resource)) + " Resource and " + CStr(bomber.Bomber_Costs(Galaxy.Produce.Gas)) + " Gas" + Environment.NewLine +
            "Description: These ships are god awful in just about every way; they fall apart if you breathe on them and they couldn’t hit a dreadnought if they were inside the damn thing but when they do hit their target you don't want to be anywhere near the blast unless you want to be vaporised. It's recommended that these ships attack in force to increase their survivability and they are most effective against larger ships." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Frigate:" + Environment.NewLine +
            "Armour: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(frigate.Frigate_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Costs: " + CStr(frigate.Frigate_Costs(Galaxy.Produce.Resource)) + " Resource and " + CStr(frigate.Frigate_Costs(Galaxy.Produce.Gas)) + " Gas" + Environment.NewLine +
            "Description: These ships are slightly larger than Fighters and Bombers and although they fire fewer shots than a fighter they do twice the damage meaning that they can take on larger ships in less numbers although they are better suited to take out enemy fighters with their increased survivability." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Destroyer:" + Environment.NewLine +
            "Armour: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(destroyer.Destroyer_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Costs: " + CStr(destroyer.Destroyer_Costs(Galaxy.Produce.Resource)) + " Resource and " + CStr(destroyer.Destroyer_Costs(Galaxy.Produce.Gas)) + " Gas" + Environment.NewLine +
            "Description: These ships, in short, are big guns with engines. They don't have the best Armour or Shields but they make up for it with crippling fire power. These ships work best when they have fighters and Frigates to act as cannon fodder so that they can dish out damage without taking return fire." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Cruiser:" + Environment.NewLine +
            "Armour: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(cruiser.Cruiser_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Costs: " + CStr(cruiser.Cruiser_Costs(Galaxy.Produce.Resource)) + " Resource and " + CStr(cruiser.Cruiser_Costs(Galaxy.Produce.Gas)) + " Gas" + Environment.NewLine +
            "Description: These ships are the backbone of any defensive or offensive manoeuvre. Their ability to soak up hits while dealing fair damage means that they can take on larger numbers with ease. Best used as a main combatant." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Dreadnought:" + Environment.NewLine +
            "Armour: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(dreadnought.Dreadnought_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Costs: " + CStr(dreadnought.Dreadnought_Costs(Galaxy.Produce.Resource)) + " Resource and " + CStr(dreadnought.Dreadnought_Costs(Galaxy.Produce.Gas)) + " Gas" + Environment.NewLine +
            "Description: These ships are your end game weapon. Their Shields can take multiple big hits and they have effective Armour; on the offensive front they almost always hit their mark with a massive payload. Though these ships are ridiculously expensive they are well worth the cost and are safest when surrounded by fighters to take hits for them." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Guardian Drone:" + Environment.NewLine +
            "Armour: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.Armour)) + Environment.NewLine +
            "MaximumShields: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.MaximumShields)) + Environment.NewLine +
            "Accuracy: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.Accuracy)) + Environment.NewLine +
            "Damage: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.Damage)) + Environment.NewLine +
            "Shots: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.Shots)) + Environment.NewLine +
            "Weight: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.Weight)) + Environment.NewLine +
            "Hanger: " + CStr(guardianDrone.Guardian_Stats(ship.Ship_Stats.Drones)) + Environment.NewLine +
            "Discription: Guardian Drones are unmanned drones. They have effective armour and damage considering their size and they come free of cost with certain ships. These drones will launch at the start of a battle and return to their hangers once the battle ends."
        Return Text
    End Function

    Private Function Environments_String()
        Dim Text =
            "Environments:" + Environment.NewLine +
            "Environments are the different areas of the game that you capture and colonise as you play." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "The Galaxy:" + Environment.NewLine +
            "The Galaxy is the largest zoom level and it allows you to view and interact with indevidual sectors and the fleets inside them. The game ends when either the player or the pirates own every sector." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Sectors:" + Environment.NewLine +
            "Sectors are collections of Systems. Sectors are aligned to whoever has the most ships inside the sector or if no ships are present someone has to own at least one system else it will become neutral again." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Systems:" + Environment.NewLine +
            "Systems are held within sectors and they can be collonised to generate supplies like Resource, Gas and Science. You need to own a sector to collonise it's systems and collonies are destroyed when their sectors allegence gets changed by an enemy." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Solar Systems" + Environment.NewLine +
            "These Systems consist of planets orbiting a star and can be collonised to generate Resource and Science Points. Solar Systems are common but that does not mean you dont take every one you can find because you need a lot of Resource to produce large ships without which you cannot win." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Nebula" + Environment.NewLine +
            "These Systems consist of clouds of Aurum-Gas which can be havested for use by colonising the nebula. Aurum-Gas is required to make ships any larger than a frigate but Nebula are rarer than Solar Systems." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "Wormholes" + Environment.NewLine +
            "Fleets move between sectors quickly using a network of wormholes. Wormholes can be closed to prevent fleets entering that sector from sectors of your choosing but this will constantly drain some of your Resource."
        Return Text
    End Function

    Private Function Factions_String()
        Dim Text As String =
            "Factions:" + Environment.NewLine +
            "Factions are the government groups that have sprung up in the chaotic wake of commercial space travel. These factions vie for control over the many galaxies in the universe though now only two really matter, The Empire of Man and The Pirate Conglomerate." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "The Empire of Man:" + Environment.NewLine +
            "The precise date and time, when humanity first stepped into the stars and claimed them as their own, has long been lost. We do know however, that for the last 6000 years, the skies have been aflame as powerful groups vied for dominion over the many galaxies now inhabited by humans but 10 years ago The Emperor stepped forward and with a small number of ships began to take systems; using superb strategy and tactics he attained victory with minimal losses and minimum collateral damage to the systems he captured. The Emperor is well loved by those he liberates due to his unwavering principle that he cannot and must not move to a new sector until infrastructure and stability have been achieved in the ones he has already captured. The Emperor no longer leads his fleets into battle and leaves this prestigious honour to his admirals who he personally selects to represent him in battle." + Environment.NewLine +
            Environment.NewLine +
            Environment.NewLine +
            "The Pirate Conglomerate:" +
            "Since The Empire was formed and took dominance in the war for control the smaller groups stopped fighting (mostly) and began to work together (somewhat) to stop the Emperor’s fleets from assuming complete control. They tend to have a very sporadic approach to stopping the Emperor’s admirals, they achieve a foothold in one sector and put their biggest ships there then lone fleets fly off and capture sectors quickly. This means that their fleets can cross back into areas they have already captured by accident and what they do own is poorly defended if at all. One advantage the pirates do have over their enemies is the ability to deploy in what seems to be an endless stream of ships but they cannot bring in the mighty dreadnoughts fielded by the empire." + Environment.NewLine
        Return Text
    End Function

End Class