namespace USWGame
{
    public partial class MainWindow : Form
    {
        public Panel gameSpace;
        (int row, int col) playerLocation;
        List<(int row, int col)> foodLocations;
        List<(int row, int col)> trapLocations;

        // Gamemap Variables
        readonly int cellSize = 64;
        readonly int numRows;
        readonly int numCols;
        // Number of squares containing food
        readonly int numFood;
        // Number of squares containing traps
        readonly int numTraps;

        // Control area
        // Extra space x
        const int xLeftMargin = 350;
        const int xRightMargin = 100;
        const int yMargin = 50;

        // Accept control input
        bool acceptControl = true;

        // Default score
        int score = 0;
        int roundsCompleted = 0;

        Label lblPlayer;
        Dictionary<string, Label> foodTiles;
        Dictionary<string, Label> trapTiles;
        Dictionary<string, Label> trailTiles;

        public delegate void QuitEventHander(object sender, QuitEventArgs e);
        public event QuitEventHander QuitGameEvent;

        public MainWindow(int numRows, int numCols, int numFood, int numTraps, int cellSize)
        {
            this.numRows = numRows;
            this.numCols = numCols;
            this.numFood = numFood;
            this.numTraps = numTraps;
            this.cellSize = cellSize;

            InitializeComponent();
            // Initialise objects
            foodLocations = new();
            trapLocations = new();
            foodTiles = new();
            trapTiles = new();
            trailTiles = new();
            gameSpace = new Panel();
        }

        /// <summary>
        /// Setup MainWindow graphical elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowLoad(object sender, EventArgs e)
        {
            // Set movement pad images
            Bitmap btnRightImage = new Bitmap(Properties.Resources.arrow, btnRight.Size);
            btnRight.Image = btnRightImage;

            // Clone image and rotate for next direction
            Bitmap btnDownImage = (Bitmap)btnRightImage.Clone();
            btnDownImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            btnDown.Image = btnDownImage;

            Bitmap btnLeftImage = (Bitmap)btnDownImage.Clone();
            btnLeftImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            btnLeft.Image = btnLeftImage;

            Bitmap btnUpImage = (Bitmap)btnLeftImage.Clone();
            btnUpImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            btnUp.Image = btnUpImage;

            SetupMainWindow();
            SetupGameSpace();

            AddFood(numFood);
            AddTraps(numTraps);

            lblPlayer = AddPlayer();
            // Bring player to front, over food, traps, trail
            lblPlayer.BringToFront();
        }

        /// <summary>
        /// Setup the size of the main window
        /// </summary>
        private void SetupMainWindow()
        {
            // Size form to accommodate size and number of grid cells and control area
            Size = new Size((numRows * cellSize) + xLeftMargin + xRightMargin, numCols * cellSize + (yMargin * 2));
        }

        /// <summary>
        /// Set up the gameSpace's variables
        /// </summary>
        private void SetupGameSpace()
        {
            gameSpace.Size = new Size(numRows * cellSize, numCols * cellSize);
            gameSpace.Name = "gameSpace";
            gameSpace.TabIndex = 0;
            gameSpace.BackColor = Color.LightPink;
            // Ensure margin is both above and below
            gameSpace.Location = new Point(xLeftMargin, yMargin / 2);
            Controls.Add(gameSpace);
        }

        /// <summary>
        /// Returns a constructed player character to the board
        /// </summary>
        /// <returns>
        /// The player <c>Label</c> object
        /// </returns>
        private Label AddPlayer()
        {
            Random rnd = new Random();
            while (true)
            {
                int playerRow = rnd.Next(numRows);
                int playerColumn = rnd.Next(numCols);
                (int row, int col) locationAttempt = (playerRow, playerColumn);

                // Prevent player from spawning on trap or food
                if (!trapLocations.Contains(locationAttempt) &&
                    !foodLocations.Contains(locationAttempt))
                {
                    playerLocation = locationAttempt;
                    return AddLabel(locationAttempt, Color.Magenta, "lblPlayer", new Bitmap(Properties.Resources.playerIcon));
                }
            }
        }

        /// <summary>
        /// Returns a constructed player character to the board
        /// </summary>
        /// <returns>
        /// The player <c>Label</c> object
        /// </returns>
        private void AddTraps(int numTraps)
        {
            Random rnd = new Random();
            int found = 0;

            while (found < numTraps)
            {
                int trapRow = rnd.Next(numRows);
                int trapColumn = rnd.Next(numCols);
                (int row, int col) trapLocation = (trapRow, trapColumn);
                // Prevent double traps and traps on food
                if (!trapLocations.Contains(trapLocation) &&
                    !foodLocations.Contains(trapLocation) &&
                    !playerLocation.Equals(trapLocation)
                    )
                {
                    string trapLabel = $"{trapLocation.row}-{trapLocation.col}-trap";
                    trapLocations.Add(trapLocation);
                    trapTiles.Add(
                        trapLabel,
                        AddLabel(trapLocation, Color.Transparent, trapLabel, new Bitmap(Properties.Resources.bombIcon), hideDefault: false)
                    );
                    found++;
                }
            }
        }

        /// <summary>
        /// Creates food Labels and adds them to a dictionary
        /// </summary>
        /// <param name="numFood">Number of food labels to add</param>
        private void AddFood(int numFood)
        {
            Random rnd = new Random();
            int found = 0;

            while (found < numFood)
            {
                int foodRow = rnd.Next(numRows);
                int foodCol = rnd.Next(numCols);
                (int row, int col) foodLocation = (foodRow, foodCol);

                if (!(foodLocations.Contains(foodLocation) || trapLocations.Contains(foodLocation) || playerLocation.Equals(foodLocation)))
                {
                    foodLocations.Add(foodLocation);
                    string foodLabel = $"{foodLocation.row}-{foodLocation.col}-food";
                    Label createdFoodLabel = AddLabel(foodLocation, Color.Transparent, foodLabel, new Bitmap(Properties.Resources.foodIcon));
                    createdFoodLabel.BringToFront();
                    foodTiles.Add(
                        foodLabel,
                        createdFoodLabel
                    );
                    found++;
                }
            }
        }

        /// <summary>
        /// Constructs a label and assigns it to gameSpace as parent
        /// </summary>
        /// <param name="location">Coordinates to place label at</param>
        /// <param name="colour">Colour of the label</param>
        /// <param name="labelText">Label's text</param>
        /// <returns>The constructed <c>Label</c> object</returns>
        private Label AddLabel((int row, int col) location, Color colour, string labelText)
        {
            // Turn into constructor function, this will allow for code reuse in future with label and label images
            Label addedLabel = new Label()
            {
                AutoSize = false,
                Size = new Size(cellSize, cellSize),
                Name = labelText,
                BackColor = colour,
                Location = new Point(location.row * cellSize, location.col * cellSize),
                Parent = gameSpace
            };
            return addedLabel;
        }

        /// <summary>
        /// Overloaded version of AddLabel.
        /// Constructs a label and assigns it to gameSpace as parent. Takes a bitmap and optional hide argument.
        /// </summary>
        /// <param name="location">Coordinates to place label at</param>
        /// <param name="colour">Colour of the label</param>
        /// <param name="labelText">Label's text</param>
        /// <param name="bitmap">Label's image</param>
        /// <param name="hideDefault">Whether to hide the label at construction</param>
        /// <returns>The constructed <c>Label</c> object</returns>
        private Label AddLabel((int row, int col) location, Color colour, string labelText, Bitmap bitmap, bool hideDefault = false)
        {
            Label addedLabel = AddLabel(location, colour, labelText);
            Bitmap resizedBitmap = new Bitmap(bitmap, addedLabel.Size);
            addedLabel.Image = resizedBitmap;
            if (hideDefault)
            {
                addedLabel.Hide();
            }
            return addedLabel;
        }

        /// <summary>
        /// Process a movement when it is clicked, determining its direction
        /// </summary>
        /// <exception cref="InvalidOperationException">Button does not have a tag</exception>
        private void MovementButtonClicked(object sender, EventArgs e)
        {
            Button buttonPressed = sender as Button;
            if (buttonPressed.Tag is null)
            {
                throw new InvalidOperationException("Expected button sender to have a tag denoting button direction");
            }
            // Button's tag contains the direction of the button
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

        /// <summary>
        /// Takes an integer, and caps the return it to the args min and max
        /// </summary>
        /// <param name="val">Integer to compare and return</param>
        /// <param name="min">Minimum value of the integer</param>
        /// <param name="max">Maximum value of the integer</param>
        /// <returns>Integer, if above max, it will be max, if below min, 
        ///          it will be min, if not it will be the original passed value
        /// </returns>
        private static int Clamp(int val, int min, int max)
        {
            if (val <= min) return min;
            if (val > max) return max;
            return val;
        }

        /// <summary>
        /// Move player and perform collision checks
        /// </summary>
        /// <param name="movementVector">Coordinates to move the player by</param>
        private void PlayerMove((int row, int col) movementVector)
        {
            // Sound.PlaySound(moveNoise);
            string trailLabelName = $"{playerLocation.row}-{playerLocation.col}-trail";
            if (!trailTiles.ContainsKey(trailLabelName))
            {
                Label createdLabel = AddLabel(playerLocation, Color.Orchid, trailLabelName);
                createdLabel.SendToBack();
                trailTiles.Add(trailLabelName, createdLabel);
            }
            playerLocation.row = Clamp(playerLocation.row + movementVector.row, 0, numRows - 1);
            playerLocation.col = Clamp(playerLocation.col + movementVector.col, 0, numCols - 1);
            lblPlayer.Location = new Point(playerLocation.row * cellSize, playerLocation.col * cellSize);
            CollisionCheck();
        }

        /// <summary>
        /// Check if the player collides with any food or traps, perform respective functions if so
        /// </summary>
        private void CollisionCheck()
        {
            ChangeRiskLabel(CountNearbyTraps());

            if (trapLocations.Contains(playerLocation))
            {
                PlayerOnTrap();
                return;
            }

            if (foodLocations.Contains(playerLocation))
            {
                PlayerOnFood();
            }
        }

        /// <summary>
        /// Process for ending game when player hits trap
        /// </summary>
        private async void PlayerOnTrap()
        {
            // Sound.PlaySound(bombNoise);
            // BackColor = Color.IndianRed;
            btnDown.Enabled = btnRight.Enabled = btnLeft.Enabled = btnUp.Enabled = false;
            // Prevent movement keyboard input
            acceptControl = false;

            // Show all traps as game is over
            foreach (Label trapLabel in trapTiles.Values)
            {
                trapLabel.Show();
            }

            BackColor = Color.IndianRed;

            await FlashDeathTile();

            MessageBox.Show("You have died");

            QuitGame();
        }

        /// <summary>
        /// Repeatedly swap the depth of trap and player to show clearly the death location
        /// </summary>
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

        /// <summary>
        /// Change the risk label and its colour
        /// </summary>
        /// <param name="nearTraps">How many traps the player is by</param>
        private void ChangeRiskLabel(int nearTraps)
        {
            lblRisk.Text = nearTraps.ToString();
            // Place this into separate function
            switch (nearTraps)
            {
                case 0:
                    lblRisk.BackColor = Color.Transparent;
                    break;
                case 1:
                    lblRisk.BackColor = Color.Yellow;
                    break;
                case 2:
                    lblRisk.BackColor = Color.Orange;
                    // Sound.PlaySound(amogus);
                    break;
                case 3:
                    lblRisk.BackColor = Color.Red;
                    break;
            }
        }

        /// <summary>
        /// Count the adjacent traps next to the player
        /// </summary>
        /// <returns>The amount of adjacent traps</returns>
        private int CountNearbyTraps()
        {
            // List of the relative vectors potential neighbours 
            List<(int row, int col)> neighbourVectors = new List<(int row, int col)> {
                (-1, -1), (0, -1), (1, -1), (-1, 0), (1, 0), (-1, 1), (0, 1), (1, 1)
            };

            int nearTraps = 0;

            // Go through each relative vector to check all adjacent squares
            foreach ((int row, int col) directionVector in neighbourVectors)
            {

                (int row, int col) checkLocation = (playerLocation.row + directionVector.row, playerLocation.col + directionVector.col);
                if (trapLocations.Contains(checkLocation))
                {
                    nearTraps++;
                }
            }
            return nearTraps;
        }

        /// <summary>
        /// Handle when a player collides with a food label
        /// </summary>
        private void PlayerOnFood()
        {
            // Sound.PlaySound(eatnoise);
            score += 10;
            lblScore.Text = score.ToString();
            string foodLabel = $"{playerLocation.row}-{playerLocation.col}-food";
            foodLocations.Remove(playerLocation);
            gameSpace.Controls.Remove(foodTiles[foodLabel]);
            foodTiles.Remove(foodLabel);

            if (foodTiles.Count == 0)
            {
                AddFood(numFood);
                if (trapTiles.Count < (numRows * numCols) / 4)
                {
                    roundsCompleted++;
                    lblRounds.Text = $"{roundsCompleted}";
                    // Add traps - Clamp ensures difficultly does is not too high on settings with with few traps
                    // e.g 100 squares with 5 traps, adds 20 traps when food is collected - too many traps
                    AddTraps((numRows * numCols) / Clamp(trapTiles.Count, 20, numRows * numCols));
                }
            }
        }

        /// <summary>
        /// Override the default ProcessCmdKey to add handling movement keys
        /// </summary>
        // Arrow keys are not accessible with default provided functions, so overrides are used
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (acceptControl)
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
            }
            return true;
        }

        /// <summary>
        /// Exits the game and returns to the main menu
        /// </summary>
        private void QuitGame()
        {
            QuitEventArgs args = new QuitEventArgs()
            {
                PlayerScore = score,
            };
            QuitGameEvent(this, args);
        }

        /// <summary>
        /// Handle when the quit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitClicked(object sender, EventArgs e)
        {
            QuitGame();
        }
    }
}
