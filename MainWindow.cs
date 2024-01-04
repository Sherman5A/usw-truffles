namespace Truffles
{
    public partial class MainWindow : Form
    {

        (int col, int row) playerLocation;
        List<(int, int)> foodLocations;
        List<(int, int)> trapLocations;
        public Panel gameSpace;

        // Gamemap Variables
        int cellSize = 64;
        int numRows = 17;
        int numCols = 13;

        // Control area
        // Extra space x
        int xSpaceShift = 400;
        // Extra space y
        int ySpaceShift = 200;

        // Number of squares containing truffles
        int numTruffles = 10;
        // Number of squares containing traps
        int numTraps = 8;
        // Default score
        int score = 0;

        public MainWindow()
        {
            InitializeComponent();
            foodLocations = new();
            trapLocations = new();
            gameSpace = new Panel();
        }

        public delegate void QuitEventHander(object sender, QuitEventArgs e);
        public event QuitEventHander QuitGameEvent;

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
        }

        // TODO: Use AddLabel instead
        private void AddTrail((int col, int row) location)
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
            Label lblPiggy = this.Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
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
            foreach ((int, int) trap in trapLocations)
            {
                AddLabel(trap, Color.LightGoldenrodYellow, "trap");
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
                    !foodLocations.Contains(trapLocation))
                {
                    trapLocations.Add(trapLocation);
                    found++;
                }
            }
        }

        private void PlotFood()
        {
            foreach ((int col, int row) truffle in foodLocations)
            {
                AddLabel(truffle, Color.DarkRed, "food");
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

                if (!foodLocations.Contains(truffleLocation))
                {
                    foodLocations.Add(truffleLocation);
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
            // Turn into constructor function, this will allow for code reuse in future with label and label images
            Label addedLabel = new Label();
            addedLabel.AutoSize = false;
            addedLabel.Size = new Size(cellSize, cellSize);
            addedLabel.Name = labelText;
            // addedLabel.BackColor = color;
            addedLabel.Location = new Point(location.col * cellSize, location.row * cellSize);
            addedLabel.Parent = gameSpace;

            if (labelText == "player")
            {
                addedLabel.Name = "lblPlayer";
                addedLabel.BackColor = Color.Green;
                addedLabel.Image = new Bitmap(Properties.Resources.playerIcon, addedLabel.Size);

            }
            else if (labelText == "food")
            {
                // Convert to string formatting
                addedLabel.Name = "lblTruffle" + location.col.ToString() + location.row.ToString();
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

        private void MovementButtonClicked(object sender, EventArgs e)
        {

            Button buttonPressed = sender as Button;
            if (buttonPressed.Tag is null)
            {
                throw new InvalidOperationException("Expected button sender to have a tag denoting button direction");
            }
            string buttonDirection = (string)buttonPressed.Tag;

            Dictionary<string, (int col, int row)> movementVector = new()
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

        private void PlayerMove((int col, int row) movementVector)
        {

            playerLocation.col = Clamp(playerLocation.col + movementVector.col, 0, numCols - 1);
            playerLocation.row = Clamp(playerLocation.row + movementVector.row, 0, numRows - 1);

            Label lblPlayer = Controls.Find("lblPlayer", true).FirstOrDefault() as Label;
            lblPlayer.Location = new Point(playerLocation.col * cellSize, playerLocation.row * cellSize);
            AddTrail(playerLocation);
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
            List<(int col, int row)> neigbourVectors = new List<(int col, int row)> {
                (-1, -1), (0, -1), (1, -1), (-1, 0), (1, 0), (-1, 1), (0, 1), (1, 1)
            };

            int nearTraps = 0;

            foreach (var directionVector in neigbourVectors)
            {
                (int col, int row) checkLocation = (playerLocation.col + directionVector.col, playerLocation.row + directionVector.row);
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

        private void RemoveLabel((int col, int row) playerLocation)
        {
            // TODO: replace with string formatting
            gameSpace.Controls.Remove(gameSpace.Controls.Find(
                "lblTruffle" + playerLocation.col.ToString() + playerLocation.row.ToString(), true)[0]
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
