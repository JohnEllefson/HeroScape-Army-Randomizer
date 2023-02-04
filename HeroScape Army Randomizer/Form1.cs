/*************************************************************
 *  Name:
 *      John Ellefson
 * 
 *  Assignment Name:
 *      Sprint #2: HeroScape Random Army Generator
 * 
 *  Assignment Description:
 *         I chose the C# module for this sprint and decided I
 *      wanted to create a random army generator for HeroScape,
 *      a tabletop wargame. There is an editible file continaing
 *      every official HeroScape figure with various of their
 *      stats/traits. This file is read in to create a list of
 *      figures to randomly create armies. Additionally, through
 *      the use of Windows Forms, there is a GUI allowing the user
 *      to easily edit various settings and to display the amries.
 * 
 *  What was the hardest part? Be as specific as possible.
 *      The hardest part of this assignment was familiarizing myself
 *      with C#. Specifically, I struggled with learning how to use
 *      Binding sources which are needed when multiple forms are
 *      created and need to interact with one another.
 * 
 *  How long did it take for you to complete the assignment?
 *      16 hours
 *****************************************************************/

using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;

namespace HeroScape_Army_Randomizer
{
    // The class for the main Form that facilitates the creation of random HeroScape armies
    public partial class Form1 : Form
    {
        // A struct that manages paramaters utilized in the random army algorithm
        public struct AlgorithmParams 
        {
            public AlgorithmParams()
            {
                generateFigureIterations = 300;
                generateArmyIterations = 100;
                allowedPoints = 500;
            }

            public int generateArmyIterations { get; }
            public int generateFigureIterations { get; }
            public int allowedPoints { get; set; }
        }

        static int selectedNameIndex = 0;
        static List<Player> players = new List<Player>();
        List<Figure> figures = new List<Figure>();
        List<Figure> allowedFigures = new List<Figure>();
        AlgorithmParams algorithmParams = new AlgorithmParams();

        // The player names list and binding source are used together
        // to allow the player list box to have the most up to date
        // player names.
        static List<String> playerNames = new List<String>();
        BindingSource namesBindingSource = new BindingSource();


        // Default constructor for the main form
        public Form1()
        {
            InitializeComponent();
        }


        // Actions taken when the main form is first loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the data source for the binding
            namesBindingSource.DataSource = playerNames;

            // Set the binding to the players listbox
            lb_PlayerList.DataSource = namesBindingSource;

            // Create two players when the program first starts since the
            // track bar initializes with a player count of 2
            players.Add(new Player("Player 1"));
            players.Add(new Player("Player 2"));

            // Update the player text box information
            updatePlayerNamesList();

            // Read in the figure data from the figure file
            readFigureFile();

            // Display player armies
            displayArmies();
        }


        // Reads the figure file, parses the data and creates a Figure object for each
        private void readFigureFile()
        {
            string name;
            FigureType type;
            bool isHero;
            int points;

            string[] lines = File.ReadAllLines(@"HeroScape_Figure_List.txt");
            string[] figureData;
            string[] typeHero;

            // Parse each figure's data and create Figure objects for each
            foreach (string line in lines)
            {
                // Ignore any lines starting with the '-' symbol
                if (line.Length >= 1 && line[0] != '-')
                {
                    // Parse the line into the figure's data
                    figureData = line.Split(", ");
                    typeHero = figureData[1].Split(" ");

                    name = figureData[0];

                    // Set the figure's type
                    if (typeHero[0] == "Common")
                        type = FigureType.Common;
                    else if (typeHero[0] == "Uncommon")
                        type = FigureType.Uncommon;
                    else if (typeHero[0] == "Unique")
                        type = FigureType.Unique;
                    else
                        type = FigureType.None;

                    // Determine if the figure is a Hero or not
                    if (typeHero[1] == "Hero")
                        isHero = true;
                    else
                        isHero = false;

                    // Set the points value
                    points = Convert.ToInt16(figureData[2]);

                    // Add the figure to the list of figures
                    figures.Add(new Figure(name, type, isHero, points));
                }
            }
        }


        // Update the list of player names
        private void updatePlayerNamesList()
        {
            playerNames.Clear();
            int playerCount = 0;
            foreach (Player p in players)
            {
                playerNames.Add(players[playerCount].getName());
                playerCount++;
            }
        }


        // Prompts the user for a new name for the selected player using Form 2
        private void btn_ChangeName_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            displayArmies();
        }


        // Changes the selected player name with what the user typed into Form 2
        internal void UpdatePlayerName(string newName)
        {
            // Update the player's name 
            players[selectedNameIndex].setName(newName);

            // Update the player text box information
            updatePlayerNamesList();
        }


        // Occurs whenever this form regains focus. Updates the binding
        // source so the list box gets the new name typed in Form 2
        private void Form1_Activated(object sender, EventArgs e)
        {
            namesBindingSource.ResetBindings(false);
        }


        // Updates the number of players when the track bar is altered
        private void tb_NumPlayers_ValueChanged(object sender, EventArgs e)
        {
            int prevPlayerNum = players.Count();
            int newPlayerNum = tb_NumPlayers.Value;

            // Add or Remove players depending on the new specified number of players
            if (prevPlayerNum < newPlayerNum)
                for (int i = prevPlayerNum + 1; i <= newPlayerNum; i++)
                    players.Add(new Player("Player " + (i)));
            else if (prevPlayerNum > newPlayerNum)
                for (int i = prevPlayerNum; i > newPlayerNum; i--)
                    players.Remove(players[i - 1]);

            // Update the player text box information
            updatePlayerNamesList();
            namesBindingSource.ResetBindings(false);

            // Update the army display
            displayArmies();
        }


        // Reevaluates which Figures fit the current specified setting constraints
        private void determineAllowedFigures()
        {
            allowedFigures.Clear();

            // Add each figure that is allowed according to the specified settings to the allowedFigures list
            foreach (Figure figure in figures)
                if ((cb_AllowHeros.Checked && figure.isHeroFig()) || (cb_AllowSquads.Checked && !figure.isHeroFig()))
                    allowedFigures.Add(figure);
        }


        // Generates a random army for each player following the given
        // constraints when the "Generate Armies" button is pressed
        private void btn_GenerateArmies_Click(object sender, EventArgs e)
        {
            int remainingPoints = 0;
            Figure chosenFigure;

            // Make each figure avaliable again
            foreach (Figure figure in allowedFigures)
                figure.setAvailability(Availability.Available);

            determineAllowedFigures();

            // Clear each player's army
            foreach (Player player in players)
            {
                player.clearArmy();
                player.setPointsUsed(0);
            }

            // Attempt to add random available figures for each player 100 times
            // NOTE: The num of iterations is an arbitrary number, but its high enough that it is 
            // extremely likely to fill up each team and use as many of their points as possible.
            for (int i = 0; i < algorithmParams.generateArmyIterations; i++)
                foreach (Player player in players)
                {
                    // Determine how many points the current player has left to spend
                    remainingPoints = algorithmParams.allowedPoints - player.getPointsUsed();

                    // Find a random figure within available points.
                    // If none are found a "NULL" figure is returned.
                    chosenFigure = chooseRandomFigure(remainingPoints);

                    // If a figure was found, add it to the player's army and
                    // subtract it's point cost from their available points.
                    if (chosenFigure.getName() != "NULL")
                    {
                        player.setPointsUsed(player.getPointsUsed() + chosenFigure.getPointCost());
                        player.addFigureToArmy(chosenFigure);
                    }
                }

            displayArmies();
        }


        // Chooses and returns a random allowed figure
        // who's cost is within the passed in point value
        private Figure chooseRandomFigure(int points)
        {
            Random rnd = new Random();
            Figure randomFigure;

            // Immediently return a "NULL" Figure since there are
            // no figures to choose from OR no points left
            if (allowedFigures.Count < 1 || points == 0)
                return new Figure();

            // Attempt to randomly find an available figure thats cheap enough
            for (int i = 0; i < algorithmParams.generateFigureIterations; i++)
            {
                // Choose a random figure
                randomFigure = allowedFigures[rnd.Next(0, allowedFigures.Count)];

                // If the random figure is available and within the point
                // price range, then set it's avaliability and return it
                if (randomFigure.getAvailability() == Availability.Available &&
                    randomFigure.getPointCost() <= points)
                {
                    // DEFAULT DUPLICATE RULES: Only unique figures are limited to 1 copy
                    if (rb_DuplicateStandard.Checked)
                    {
                        if (randomFigure.getType() == FigureType.Unique)
                            randomFigure.setAvailability(Availability.Taken);
                    }

                    // DUPLICATE COMMON FIGURES: All figures execpt common figures are limited to 1 copy
                    else if (rb_DuplicateCommonFigures.Checked)
                    {
                        if (randomFigure.getType() != FigureType.Common)
                            randomFigure.setAvailability(Availability.Taken);
                    }

                    // NO DUPLICATES: All figures are limited to 1 copy
                    else if (rb_NoDuplicates.Checked)
                        randomFigure.setAvailability(Availability.Taken);

                    // DUPLICATE ALL FIGURES: All figures can have unlimited copies
                    // NOTE: No code required to implement this option since all
                    // figure's are available by default and will stay that way

                    //Return the chosen figure
                    return randomFigure;
                }
            }

            // Return a "NULL" Figure indicating that a valid figure was not found
            return new Figure();
        }


        // When the points setting is altered, update the "alowedPoints" variable
        private void nud_Points_ValueChanged(object sender, EventArgs e)
        {
            // Update the allowed points to the value specified
            algorithmParams.allowedPoints = Convert.ToInt32(nud_Points.Value);
        }


        // Create a new army to replace the currently selected player's army
        private void btn_Reroll_Click(object sender, EventArgs e)
        {
            int remainingPoints = 0;
            Figure chosenFigure;

            // Make each figure from the chosen player's previous army avaliable again
            for (int i = 0; i <= players[selectedNameIndex].getArmySize() - 1; i++)
                players[selectedNameIndex].getArmyFigure(i).setAvailability(Availability.Available);

            determineAllowedFigures();

            // Clear the player's previous army and reset their used points
            players[selectedNameIndex].clearArmy();
            players[selectedNameIndex].setPointsUsed(0);

            // Attempt to add random available figures for each player 100 times
            // NOTE: The number of iterations is an arbitrary number, but its high enough that it is 
            // extremely likely to fill up each team and use as many of their points as possible.
            for (int i = 0; i < algorithmParams.generateArmyIterations; i++)
            {
                // Determine how many points the current player has left to spend
                remainingPoints = algorithmParams.allowedPoints - players[selectedNameIndex].getPointsUsed();

                // Find a random figure within available points.
                // If none are found a "NULL" figure is returned.
                chosenFigure = chooseRandomFigure(remainingPoints);

                // If a figure was found, add it to the player's army and
                // subtract it's point cost from their available points.
                if (chosenFigure.getName() != "NULL")
                {
                    players[selectedNameIndex].setPointsUsed(players[selectedNameIndex].getPointsUsed() + chosenFigure.getPointCost());
                    players[selectedNameIndex].addFigureToArmy(chosenFigure);
                }
            }

            // Display the updated armies
            displayArmies();
        }


        // Updates the main display rich text box to have all player's army information
        internal void displayArmies()
        {
            // Clear the main display
            rtb_MainDisplay.Clear();

            // Print each player's army on the main display
            foreach (Player player in players)
            {
                // Print player name
                rtb_MainDisplay.AppendText(player.getName() + ":\n");

                // Print the Player's army
                for (int i = 0; i <= player.getArmySize() - 1; i++)
                    rtb_MainDisplay.AppendText("    - " + player.getArmyFigure(i).getName() + "\n");

                // Print total points used and create spacing between each player's army
                rtb_MainDisplay.AppendText(" Points Used: " + player.getPointsUsed() + "\n\n");
            }
        }


        // Updates the currently selected player
        private void lb_PlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNameIndex = lb_PlayerList.SelectedIndex;
        }


        // Adds a new player so long as there wont be over the max of 6 players
        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            // Immediately return if adding this player
            // would cause there to be more than 6 players
            if (tb_NumPlayers.Value + 1 > 6)
                return;

            tb_NumPlayers.Value = tb_NumPlayers.Value + 1;

            // Display the updated armies
            displayArmies();
        }


        // Removes the currently selected player
        private void btn_RemovePlayer_Click(object sender, EventArgs e)
        {
            // Immediately return if removing this player
            // would leave fewer than 2 players remaining
            if (tb_NumPlayers.Value - 1 < 2)
                return;

            // Relocate the selected figure to be deleted to the last element,
            // so that when the player number trackbar is decresed, the player
            // that gets cut off and deleted is the selected relocated player. 
            players.Add(players[selectedNameIndex]);
            players.Remove(players[selectedNameIndex]);
            tb_NumPlayers.Value = tb_NumPlayers.Value - 1;

            // Display the updated armies
            displayArmies();
        }
    }
}