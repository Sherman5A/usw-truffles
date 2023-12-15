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
                    AddLabel(locationAttempt, Color.Magenta);
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
            foreach ((int, int) truffle in truffleLocations)
            {
                AddLabel(truffle, Color.DarkRed);
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
            addedLabel.Name = "lable1";
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
    }
}
