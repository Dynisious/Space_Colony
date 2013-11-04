Public Class tutorialWindow
    Private WithEvents T As New Timer With {.Enabled = True, .Interval = 1500}
    Public Enum Messages
        Min
        Intro
        TheGalaxy
        SelectingAndMoving
        Colonising
        MakingShips
        ClosingWormholes
        Combat
        TheEnemy
        VictoryAndLose
        Outro
        Max
    End Enum
    Public Message As Messages
    Public Strings As New Dictionary(Of Messages, String) From {
    {Messages.Intro,
        "Introduction:" + Environment.NewLine +
        "Ah you must be the new admiral! I am the Drill Sargent of this base so you will know me only as sir." + Environment.NewLine +
        "In this tutorial you will learn the basics of how to command your fleets and conquer the galaxy." + Environment.NewLine +
        "To Proceed through this tutorial press the Next button. If at any time you want to return to a previous instruction press the Previous button. The game is currently paused; pausing is toggled with the pause button. Pressing either Next or Previous will automatically pause the game."},
    {Messages.TheGalaxy,
        "The Galaxy:" + Environment.NewLine +
        "The galaxy is divided into a large 27x10 grid; each square in this grid is a sector. Sectors can be zoomed into with a right click to view its Systems and zoomed out of with the button below the grid. Each squares border indicates something about it; Green you own it, Yellow no one owns it and Red it's owned by pirates. Furthermore the numbers inside sectors indicate how many fleets are inside the sector. To view information about a sector or a system click it once and information will display in the box at the bottom right of the screen. Such as who owns it, the number of systems it holds (colonised and un-colonised) and the number of each ship type contained inside it."},
    {Messages.SelectingAndMoving,
        "Selecting and Moving:" + Environment.NewLine +
        "To select your fleets you need to double click on one of your sectors with one or more of your fleets inside it. The window that opens lets you choose between any of your fleets in that sector by double clicking on one of the buttons. Once you have selected a fleet, sectors that you can move into turn blue. To move the fleet double click on a highlighted sector. Observe how the sectors border turns green; this means it is yours as long as you have a fleet inside it."},
    {Messages.Colonising,
        "Colonising:" + Environment.NewLine +
        "I assume you've followed orders and your ships remains in a sector you haven't yet colonised. Now if you right click that sector you can enter it and begin to colonise. The yellow squares represent the systems inside the sector you just right clicked; to colonise a system just double click it and it will turn green and you will lose some Resource. This system will now begin to produce either Resource and Science or Aurum Gas. Now if you were to move your ships out of that sector it will remain yours; you only need to own one system to control the sector but you get more supplies by owning all of them. Resource is the most common supply and it is used to colonise and pay for ships but larger more powerful ships require Aurum Gas as well which is much rarer."},
    {Messages.MakingShips,
        "Building your Fleets:" + Environment.NewLine +
        "Now click on the button labelled ‘Add Ships’ and then click on a sector that you own. Either make a new fleet or add ships to an existing fleet by doubling clicking a fleet or the ‘New Fleet’ button; all fleets start with one fighter. The next screen lets you choose what ships to add and it displays the costs of each ship beside the type of ship as ‘Resource/Gas’. The total cost of your selection, your current supplies and how many ship-points you’re using are displayed bellow (ship-points limit how many ships you can have in one fleet). Once you are done click Accept and if you don’t exceed the limits the ships will be added to your fleet. Now you can see the ships are in that sector by clicking the sector once and looking at its stats."},
    {Messages.ClosingWormholes,
        "Wormholes:" + Environment.NewLine +
        "If you click the ‘Close Wormholes’ button and then click a sector you own, you can close any of its wormholes. You pay 6 Resource/Second for each wormhole closed but in return your enemies can enter that sector from the areas you close off but you can still leave that sector making it excellent for choke points. Warning you cannot enter a sector from closed off areas either."},
    {Messages.Combat,
        "Combat:" + Environment.NewLine +
        "Now for the fun stuff, Combat! Whenever you start a game there will be four pirate fleets in the bottom right corner of the screen; One of them will be ridiculously powerful but it will not move, on the other hand the remaining three will fly off and start taking sectors. Pirates will be a constant thorn in your side I can promise you that, so like any weed we must burn them out! Add some more ships to your fleets and then lead them over to the enemy. If you enter the same sector as an enemy fleet you will engage them but they will shoot back so make sure they aren't too powerful for you! The sector will align itself to the team with the most ships in that sector. Speak to me again once you are victorious."},
    {Messages.TheEnemy,
        "The Enemy:" + Environment.NewLine +
        "The enemy fleets we are fighting against are owned by the Pirate Conglomerate. These blighters are well armed and supplied and they are trying to take control of these galaxies for themselves. We cannot let them have them by Terra! They will come in with increasingly powerful ships and attempt colonise systems but once they control a sector they move through it very quickly so just sending a small runner through territory they aren’t protecting to remove their colonies can slow them dramatically as they stop to retake the sector. One advantage we do have over them is the ability to construct dreadnoughts; the pirates do not have the ability to create them beyond the few they manage to capture so they will be a great asset to us."},
    {Messages.VictoryAndLose,
        "Victory and Loss:" + Environment.NewLine +
        "To win the game you must own every sector in the galaxy; this means owning at least one system in each. Be warned, the longer you wait the more powerful the enemy will become and if the pirates wipe you off the map your mission will be a failure; I do not tolerate failure."},
    {Messages.Outro,
        "Outro:" + Environment.NewLine +
        "Well I've done all I can for you so now if you return to the home screen and press ‘New Game’ button we can shoot you off into deep space to begin expanding The Empire of Man. Unless you don’t feel ready in which case feel free to look back through this tutorial and to fend off the pirates here with your superior fire power."}
    }

    Public Sub New()
        InitializeComponent()

        Message = Messages.Intro
        lbl.Text = Strings(Message)
        Visible = True
        Screen.Pause_Click(Me, New EventArgs)
    End Sub

    Private Sub PreviousInstruction_Click(sender As System.Object, e As System.EventArgs) Handles PreviousInstruction.Click
        If Message - 1 <> Messages.Min Then
            If Screen.GameGalaxy.WorldTimer.Enabled = True Then
                Screen.Pause_Click(Me, New EventArgs)
            End If
            Message = Message - 1
            lbl.Text = Strings(Message)
        End If
    End Sub

    Private Sub NextInstruction_Click(sender As System.Object, e As System.EventArgs) Handles NextInstruction.Click
        If Message + 1 <> Messages.Max Then
            If Screen.GameGalaxy.WorldTimer.Enabled = True Then
                Screen.Pause_Click(Me, New EventArgs)
            End If
            Message = Message + 1
            lbl.Text = Strings(Message)
        End If
    End Sub

    Private Sub T_Tick() Handles T.Tick
        BringToFront()
    End Sub
End Class