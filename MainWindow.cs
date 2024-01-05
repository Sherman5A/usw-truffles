namespace USWGame
{
    public partial class MainWindow : Form
    {
        public Panel gameSpace;
        (int row, int col) playerLocation;
        List<(int row, int col)> foodLocations;
        List<(int row, int col)> trapLocations;

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

        Label lblPlayer;
        Dictionary<string, Label> foodTiles;
        Dictionary<string, Label> trapTiles;
        Dictionary<string, Label> trailTiles;

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
            foodTiles = new();
            trapTiles = new();
            trailTiles = new();
            gameSpace = new Panel();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            SetupMainWindow();
            SetupGameSpace();

            AddFood(numFood);

            AddTraps(numTraps);

            lblPlayer = AddPlayer();
            // Bring player to front, over food, traps, trail
            lblPlayer.BringToFront();
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
            gameSpace.Location = new Point(xLeftMargin, yMargin / 2);
            Controls.Add(gameSpace);
        }

        /// <summary>
        /// Adds the player character to the board
        /// </summary>
        private Label AddPlayer()
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
                    return AddLabel(locationAttempt, Color.Magenta, "lblPlayer", new Bitmap(Properties.Resources.playerIcon));
                }
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
                    string trapLabel = $"{trapLocation.row}-{trapLocation.col}-trap";
                    trapTiles.Add(
                        trapLabel,
                        AddLabel(trapLocation, Color.LightGoldenrodYellow, trapLabel, new Bitmap(Properties.Resources.bombIcon), hideDefault: true)
                    );
                    found++;
                }
            }
        }

        private void AddFood(int numFood)
        {
            Random rnd = new Random();
            int found = 0;

            while (found < numFood)
            {
                int foodRow = rnd.Next(numRows);
                int foodCol = rnd.Next(numCols);
                (int row, int col) foodLocation = (foodRow, foodCol);

                if (!foodLocations.Contains(foodLocation))
                {
                    foodLocations.Add(foodLocation);
                    string foodLabel = $"{foodLocation.row}-{foodLocation.col}-food";
                    foodTiles.Add(
                        foodLabel,
                        AddLabel(foodLocation, Color.DarkRed, foodLabel, new Bitmap(Properties.Resources.foodIcon))
                    );
                    found++;
                }
            }
        }

        private Label AddLabel((int row, int col) location, Color color, string labelText)
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
            return addedLabel;
        }

        private Label AddLabel((int row, int col) location, Color color, string labelText, Bitmap bitmap, bool hideDefault = false)
        {
            Label addedLabel = AddLabel(location, color, labelText);
            Bitmap resizedBitmap = new Bitmap(bitmap, addedLabel.Size);
            addedLabel.Image = resizedBitmap;
            if (hideDefault)
            {
                addedLabel.Hide();
            }
            return addedLabel;
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
            string trailLabelName = $"{playerLocation.row}-{playerLocation.col}-trail";
            if (!trailTiles.ContainsKey(trailLabelName))
            {
                trailTiles.Add(
                    trailLabelName,
                    AddLabel(playerLocation, Color.Orchid, trailLabelName)
                );
            }
            playerLocation.row = Clamp(playerLocation.row + movementVector.row, 0, numRows - 1);
            playerLocation.col = Clamp(playerLocation.col + movementVector.col, 0, numCols - 1);
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

        private async void PlayerOnTrap()
        {
            btnDown.Enabled = btnRight.Enabled = btnLeft.Enabled = btnUp.Enabled = false;
            // Show all traps
            foreach (Label trapLabel in trapTiles.Values)
            {
                trapLabel.Show();
            }
            BackColor = Color.LightPink;

            await FlashDeathTile();

            MessageBox.Show("You have died");

            QuitEventArgs args = new QuitEventArgs()
            {
                PlayerScore = score,
            };
            QuitGameEvent(this, args);
        }

        private async Task FlashDeathTile()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(500);
                trapTiles[$"{playerLocation.row}-{playerLocation.col}-trap"].BringToFront();
                await Task.Delay(500);
                lblPlayer.BringToFront();
            }
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
        }

        private void PlayerOnFood()
        {
            score += 10;
            lblScore.Text = score.ToString();
            foodLocations.Remove(playerLocation);
            RemoveFood(playerLocation);
        }

        private void RemoveFood((int row, int col) playerLocation)
        {
            gameSpace.Controls.Remove(foodTiles[$"{playerLocation.row}-{playerLocation.col}-food"]);
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
