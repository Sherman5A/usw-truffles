using System.Diagnostics;
using System.Runtime.Versioning;

namespace Truffles
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Globals
        int cellSize = 64;
        int numRows = 17;
        int numCols = 13;

        // Extra space x
        int xSpaceShift = 400;
        // Extra space y
        int ySpaceShift = 200;

        List<(int, int)> truffleLocations = new();
        List<(int, int)> trapLocations = new();

        // Number of squares containing truffles
        int numTruffles = 10;
        // Number of squares containing traps
        int numTraps = 8;

        (int col, int row) playerLocation;


        int score = 0;
        public Panel gameSpace = new Panel();



        private void MainWindowLoad(object sender, EventArgs e)
        {
            SetupMainWindow();
            SetupGameSpace();
            // AddLabel(6, 8);
            AddFood(numTruffles);
            PlotFood();

            AddTraps(numTraps);
            PlotTraps();

            AddPlayer();
            PlayerOnTop();
            lblRisk.Text = countTraps();
        }
        private string countTraps()
        {
            // TODO: rewrite this with a matrix

            int count = 0;

            if (playerLocation.col > 0)
            {
                (int, int) adjacentTile = (playerLocation.col - 1, playerLocation.row);
                if (trapLocations.Contains(adjacentTile))
                {
                    count++;
                }
            }

            if (playerLocation.col < numCols - 1)
            {
                (int, int) adjacentTile = (playerLocation.col + 1, playerLocation.row);
                if (trapLocations.Contains(adjacentTile))
                {
                    count++;
                }
            }

            if (playerLocation.row > 0)
            {
                (int, int) adjacentTile = (playerLocation.col, playerLocation.row - 1);
                if (trapLocations.Contains(adjacentTile))
                {
                    count++;
                }
            }

            if (playerLocation.row < numCols - 1)
            {
                (int, int) adjacentTile = (playerLocation.col, playerLocation.row + 1);
                if (trapLocations.Contains(adjacentTile))
                {
                    count++;
                }
            }
            return count.ToString();
        }

        // TODO: Use AddLabel instead
        private void addTrail((int col, int row) location)
        {
            Label addLabel = new Label();
            addLabel.AutoSize = false;
            addLabel.Size = new Size(cellSize, cellSize);
            addLabel.Location = new Point(location.col * cellSize, location.row * cellSize);
            addLabel.BackColor = Color.Orchid;
            addLabel.Parent = gameSpace;
        }

        private void PlayerOnTop()
        {
            Label lblPiggy = this.Controls.Find("lblPLayer", true).FirstOrDefault() as Label;
            lblPiggy.BringToFront();
        }

        /// <summary>
        /// Adds the player character to the board
        /// </summary>
        private void AddPlayer()
        {
            Random rnd = new Random();
            while (true)
            {
                int playerRow = rnd.Next(numRows);
                int playerColumn = rnd.Next(numCols);
                (int, int) locationAttempt = (playerColumn, playerRow);

                if (!trapLocations.Contains(locationAttempt) &&
                    !truffleLocations.Contains(locationAttempt))
                {
                    playerLocation = locationAttempt;
                    AddLabel(locationAttempt, Color.Magenta, "lblPlayer");
                    break;
                }
            }
        }

        private void PlotTraps()
        {
            foreach ((int, int) trap in trapLocations)
            {
                AddLabel(trap, Color.LightGoldenrodYellow);
            }
        }

        private void AddTraps(int numTraps)
        {
            Random rnd = new Random();
            int found = 0;

            while (found < numTraps)
            {
                int trapRow = rnd.Next(numRows);
                int trapColumn = rnd.Next(numCols);
                (int, int) trapLocation = (trapColumn, trapRow);

                if (!trapLocations.Contains(trapLocation) &&
                    !truffleLocations.Contains(trapLocation))
                {
                    trapLocations.Add(trapLocation);
                    found++;
                }
            }
        }

        private void PlotFood()
        {
            string name;
            int i = 0;

            foreach ((int col, int row) truffle in truffleLocations)
            {
                // TODO: string formatting
                name = "lblTruffle" + truffle.col.ToString() + truffle.row.ToString();
                AddLabel(truffle, Color.DarkRed, name);
            }
        }

        private void AddFood(int numTruffles)
        {
            Random rnd = new Random();
            int found = 0;

            while (found < numTruffles)
            {
                int truffleRow = rnd.Next(numRows);
                int truffleCol = rnd.Next(numCols);
                (int, int) truffleLocation = (truffleCol, truffleRow);

                if (!truffleLocations.Contains(truffleLocation))
                {
                    truffleLocations.Add(truffleLocation);
                    found++;
                }

            }
        }

        private void AddLabel(int labelColumn, int labelRow)
        {
            Label addedLabel = new Label();
            addedLabel.AutoSize = false;
            addedLabel.Size = new Size(cellSize, cellSize);
            addedLabel.Name = "label1";
            addedLabel.Text = "F";
            addedLabel.TextAlign = ContentAlignment.MiddleCenter;
            addedLabel.BackColor = Color.LightBlue;
            addedLabel.Location = new Point(labelColumn * cellSize, labelRow * cellSize);
            addedLabel.Parent = gameSpace;
        }

        private void AddLabel((int col, int row) location, Color color)
        {
            Label addedLabel = new Label();
            addedLabel.AutoSize = false;
            addedLabel.Size = new Size(cellSize, cellSize);
            addedLabel.BackColor = color;
            addedLabel.Location = new Point(location.col * cellSize, location.row * cellSize);
            addedLabel.Parent = gameSpace;
        }

        private void AddLabel((int col, int row) location, Color color, String labelText)
        {
            Label addedLabel = new Label();
            addedLabel.AutoSize = false;
            addedLabel.Size = new Size(cellSize, cellSize);
            addedLabel.Name = labelText;
            addedLabel.BackColor = color;
            addedLabel.Location = new Point(location.col * cellSize, location.row * cellSize);
            addedLabel.Parent = gameSpace;
        }

        private void SetupMainWindow()
        {
            // Size form to accommodate size and number of grid cells and control area
            Size = new Size(numCols * cellSize + xSpaceShift, numRows * cellSize + ySpaceShift);
        }

        private void SetupGameSpace()
        {
            gameSpace.Size = new Size(numCols * cellSize, numRows * cellSize);
            gameSpace.Name = "gameSpace";
            gameSpace.TabIndex = 0;
            gameSpace.BackColor = Color.LightPink;
            gameSpace.Location = new Point(xSpaceShift - 50, ySpaceShift - 100);

            Controls.Add(gameSpace);
        }

        // TODO: Reduce to smaller functions
        private void btnLeftClick(object sender, EventArgs e)
        {
            if (playerLocation.col > 0)
            {
                addTrail(playerLocation);
                playerLocation.col--;
                Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
                lblPlayer.Location = new Point(playerLocation.col * cellSize, playerLocation.row * cellSize);
                lblRisk.Text = countTraps();

                if (trapLocations.Contains(playerLocation))
                {
                    playerOnTrap();
                }

                if (truffleLocations.Contains(playerLocation))
                {
                    playerOnTruffle();
                }
            }

        }

        private void btnUpClick(object sender, EventArgs e)
        {
            if (playerLocation.row > 0)
            {
                addTrail(playerLocation);
                playerLocation.row--;
                Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
                lblPlayer.Location = new Point(playerLocation.col * cellSize, playerLocation.row * cellSize);
                lblRisk.Text = countTraps();

                if (trapLocations.Contains(playerLocation))
                {
                    playerOnTrap();

                }

                if (truffleLocations.Contains(playerLocation))
                {
                    playerOnTruffle();
                }
            }

        }

        private void btnRightClick(object sender, EventArgs e)
        {
            if (playerLocation.col < numCols - 1)
            {
                addTrail(playerLocation);
                playerLocation.col++;
                Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
                lblPlayer.Location = new Point(playerLocation.col * cellSize, playerLocation.row * cellSize);
                lblRisk.Text = countTraps();

                if (trapLocations.Contains(playerLocation))
                {
                    playerOnTrap();
                }

                if (truffleLocations.Contains(playerLocation))
                {
                    playerOnTruffle();
                }
            }
        }



        private void btnDownClick(object sender, EventArgs e)
        {
            if (playerLocation.row < numRows - 1)
            {
                addTrail(playerLocation);
                playerLocation.row++;
                Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
                lblPlayer.Location = new Point(playerLocation.col * cellSize, playerLocation.row * cellSize);
                lblRisk.Text = countTraps();

                // TODO: Use else if or switch of sort
                if (trapLocations.Contains(playerLocation))
                {
                    playerOnTrap();

                }

                if (truffleLocations.Contains(playerLocation))
                {
                    playerOnTruffle();
                }
            }
        }

        private void playerOnTrap()
        {
            MessageBox.Show("You died");
            btnDown.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;    
            btnUp.Enabled = false;
        }

        private void playerOnTruffle()
        {
            score += 10;
            lblScore.Text = score.ToString();
            Debug.WriteLine(score.ToString());
            truffleLocations.Remove(playerLocation);
            removeLabel(playerLocation);

        }

        private void removeLabel((int col, int row) playerLocation)
        {
            // TODO: replace with string formatting
            gameSpace.Controls.Remove(gameSpace.Controls.Find(
                "lblTruffle" + playerLocation.col.ToString() + playerLocation.row.ToString(),true)[0]
            );

        }
    }
}
