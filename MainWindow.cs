using System.Diagnostics;

namespace USWGame
{
    public partial class MainWindow : Form
    {
        (int row, int col) playerLocation;
        List<(int row, int col)> foodLocations;
        List<(int row, int col)> trapLocations;
        public Panel gameSpace;

        // Gamemap Variables
        int cellSize = 64;
        int numRows;
        int numCols;
        // Number of squares containing food
        int numFood;
        // Number of squares containing traps
        int numTraps;

        // Control area
        // Extra space x
        int xLeftMargin = 300;
        int xRightMargin = 100;
        int yMargin = 50;
        // Default score
        int score = 0;
        public delegate void QuitEventHander(object sender, QuitEventArgs e);
        public event QuitEventHander QuitGameEvent;

        public MainWindow(int numRows, int numCols, int numFood, int numTraps)
        {
            this.numRows = numRows;
            this.numCols = numCols;
            this.numFood = numFood;
            this.numTraps = numTraps;

            InitializeComponent();
            foodLocations = new();
            trapLocations = new();
            gameSpace = new Panel();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            SetupMainWindow();
            SetupGameSpace();

            AddFood(numFood);
            PlotFood();

            AddTraps(numTraps);
            PlotTraps();

            AddPlayer();
            PlayerOnTop();
        }

        private void SetupMainWindow()
        {
            // Size form to accommodate size and number of grid cells and control area
            Size = new Size((numRows * cellSize) + xLeftMargin + xRightMargin, numCols * cellSize + (yMargin * 2));
        }

        private void SetupGameSpace()
        {
            gameSpace.Size = new Size(numRows * cellSize, numCols * cellSize);
            gameSpace.Name = "gameSpace";
            gameSpace.TabIndex = 0;
            gameSpace.BackColor = Color.LightPink;
            gameSpace.Location = new Point(xLeftMargin, 0 + yMargin);

            Controls.Add(gameSpace);
        }

        private void PlayerOnTop()
        {
            Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
            lblPlayer.BringToFront();
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
                (int row, int col) locationAttempt = (playerRow, playerColumn);

                if (!trapLocations.Contains(locationAttempt) &&
                    !foodLocations.Contains(locationAttempt))
                {
                    playerLocation = locationAttempt;
                    AddLabel(locationAttempt, Color.Magenta, "player");
                    break;
                }
            }
        }

        private void PlotTraps()
        {
            foreach ((int row, int col) trapLocation in trapLocations)
            {
                AddLabel(trapLocation, Color.LightGoldenrodYellow, "trap");
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
                (int row, int col) trapLocation = (trapRow, trapColumn);

                if (!trapLocations.Contains(trapLocation) &&
                    !foodLocations.Contains(trapLocation))
                {
                    trapLocations.Add(trapLocation);
                    found++;
                }
            }
        }

        private void PlotFood()
        {
            foreach ((int row, int col) foodLocation in foodLocations)
            {
                AddLabel(foodLocation, Color.DarkRed, "food");
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
                (int row, int col) truffleLocation = (truffleRow, truffleCol);

                if (!foodLocations.Contains(truffleLocation))
                {
                    foodLocations.Add(truffleLocation);
                    found++;
                }
            }
        }

        private void AddLabel((int row, int col) location, Color color, string labelText)
        {
            // Turn into constructor function, this will allow for code reuse in future with label and label images
            Label addedLabel = new Label
            {
                AutoSize = false,
                Size = new Size(cellSize, cellSize),
                Name = labelText,
                BackColor = color,
                Location = new Point(location.row * cellSize, location.col * cellSize),
                Parent = gameSpace
            };

            if (labelText == "player")
            {
                addedLabel.Name = "lblPlayer";
                addedLabel.BackColor = Color.Green;
                addedLabel.Image = new Bitmap(Properties.Resources.playerIcon, addedLabel.Size);

            }
            else if (labelText == "food")
            {
                // Convert to string formatting
                addedLabel.Name = "lblTruffle" + location.row.ToString() + location.col.ToString();
                addedLabel.BackColor = Color.DarkRed;
                // "food"
                addedLabel.Image = new Bitmap(Properties.Resources.foodIcon, addedLabel.Size);
            }
            else if (labelText == "trap")
            {
                addedLabel.Name = "lblTrap";
                addedLabel.BackColor = Color.LightGoldenrodYellow;
                addedLabel.Image = new Bitmap(Properties.Resources.bombIcon, addedLabel.Size);
            }
        }

        private void MovementButtonClicked(object sender, EventArgs e)
        {

            Button buttonPressed = sender as Button;
            if (buttonPressed.Tag is null)
            {
                throw new InvalidOperationException("Expected button sender to have a tag denoting button direction");
            }
            string buttonDirection = (string)buttonPressed.Tag;

            Dictionary<string, (int row, int col)> movementVector = new()
            {
                { "left", ( -1, 0)},
                { "right", ( 1, 0)},
                { "up",  (0, -1)},
                { "down", (0, 1)},
            };

            PlayerMove(movementVector[buttonDirection]);
        }

        private static int Clamp(int val, int min, int max)
        {
            if (val <= min) return min;
            if (val > max) return max;
            return val;
        }

        private void PlayerMove((int row, int col) movementVector)
        {
            AddLabel(playerLocation, Color.Orchid, $"{playerLocation.row}-{playerLocation.col}-trail");
            playerLocation.row = Clamp(playerLocation.row + movementVector.row, 0, numRows - 1);
            playerLocation.col = Clamp(playerLocation.col + movementVector.col, 0, numCols - 1);

            Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
            lblPlayer.Location = new Point(playerLocation.row * cellSize, playerLocation.col * cellSize);

            CollisionCheck();
        }

        private void CollisionCheck()
        {
            if (trapLocations.Contains(playerLocation))
            {
                PlayerOnTrap();
                return;
            }

            if (foodLocations.Contains(playerLocation))
            {
                PlayerOnFood();
            }
            ChangeRiskLabel(CountNearbyTraps());
        }

        private void PlayerOnTrap()
        {
            btnDown.Enabled = btnRight.Enabled = btnLeft.Enabled = btnUp.Enabled = false;
            PlotTraps();
            MessageBox.Show("You died");

            QuitEventArgs args = new QuitEventArgs()
            {
                PlayerScore = score,
            };
            QuitGameEvent(this, args);
        }

        private void ChangeRiskLabel(int nearTraps)
        {
            lblRisk.Text = nearTraps.ToString();
            // Place this into seperate function
            switch (nearTraps)
            {
                case 0:
                    lblRisk.BackColor = Color.White;
                    break;
                case 1:
                    lblRisk.BackColor = Color.Yellow;
                    break;
                case 2:
                    lblRisk.BackColor = Color.Orange;
                    break;
                case 3:
                    lblRisk.BackColor = Color.Red;
                    break;
            }
        }

        private int CountNearbyTraps()
        {
            // List of the relative vectors potential neigbours 
            List<(int row, int col)> neigbourVectors = new List<(int row, int col)> {
                (-1, -1), (0, -1), (1, -1), (-1, 0), (1, 0), (-1, 1), (0, 1), (1, 1)
            };

            int nearTraps = 0;

            foreach (var directionVector in neigbourVectors)
            {
                (int row, int col) checkLocation = (playerLocation.row + directionVector.row, playerLocation.col + directionVector.col);
                if (trapLocations.Contains(checkLocation))
                {
                    nearTraps++;
                }
            }
            return nearTraps;
            // TODO: Add an update count function after this
        }

        private void PlayerOnFood()
        {
            score += 10;
            lblScore.Text = score.ToString();
            foodLocations.Remove(playerLocation);
            RemoveLabel(playerLocation);

        }

        private void RemoveLabel((int row, int col) playerLocation)
        {
            // TODO: replace with string formatting
            gameSpace.Controls.Remove(gameSpace.Controls.Find(
                "lblTruffle" + playerLocation.row.ToString() + playerLocation.col.ToString(), true)[0]
            );

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // Movement keys
                case Keys.Up:
                case Keys.W:
                    // Parameter is the vector to move the player up by 1 cell
                    PlayerMove((0, -1));
                    break;
                case Keys.Down:
                case Keys.S:
                    PlayerMove((0, 1));
                    break;
                case Keys.Left:
                case Keys.A:
                    PlayerMove((-1, 0));
                    break;
                case Keys.Right:
                case Keys.D:
                    PlayerMove((1, 0));
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);

            }
            return true;
        }
    }
}
