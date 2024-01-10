
using System.Diagnostics;

namespace USWGame
{
    public partial class Menu : Form
    {
        Size screenSize;
        private string scoresPath = "scores.txt";
        private MainWindow mainWindow;
        private List<string> scores = new();
        private ListViewNumberSort listNumSort;
        private Settings settings;
        private int cellSize = 64;

        public Menu()
        {
            InitializeComponent();
            screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            listNumSort = new ListViewNumberSort()
            {
                OrderSort = SortOrder.Descending,
                SortColumn = 0,
            };
            settings = new Settings();
        }

        /// <summary>
        /// Runs when the menu first loads
        /// </summary>
        private void MenuLoad(object sender, EventArgs e)
        {
            LoadScores();
            AssignSettings();
        }

        /// <summary>
        /// Assigns the numeric boxes values' to the values read from the settings
        /// file
        /// </summary>
        private void AssignSettings()
        {
            numRow.Value = settings.NumRows;
            numCol.Value = settings.NumCols;
            numTraps.Value = settings.NumTraps;
            numFood.Value = settings.NumFood;
        }

        /// <summary>
        /// Load the scores from <c>scoresPath</c>, adds them to the scoreboard, and then
        /// sorts them into order
        /// </summary>
        private void LoadScores()
        {
            // Create file if it does not exist
            using (FileStream createFileIfNotExist = File.Open(scoresPath, FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(createFileIfNotExist);
                // Read each line unil the end of the file
                string fileLine;
                while ((fileLine = sr.ReadLine()) != null)
                {
                    scores.Add(fileLine);
                }
            }
            // Sort highest to lowest
            listScoreView.Sorting = SortOrder.Descending;
            listScoreView.ListViewItemSorter = listNumSort;
            scores.ForEach(s =>
            {
                listScoreView.Items.Add(s);
            });
            listScoreView.Sort();
        }

        /// <summary>
        /// Quit completely out of the main menu
        /// </summary>
        private void BtnQuitClicked(object sender, EventArgs e)
        {
            mainWindow?.Close();
            Close();
        }

        private bool ValidateDimensions()
        {
            Debug.WriteLine(numRow.Value * cellSize > (screenSize.Width - 200));
            Debug.WriteLine(numCol.Value * cellSize > (screenSize.Height - 200));

            if (numRow.Value * cellSize > (screenSize.Width - 200) || numCol.Value * cellSize > (screenSize.Height - 200))
            {
                MessageBox.Show($"Rows or columns too high{Environment.NewLine}" +
                    $"Screen size: {screenSize.Width}x{screenSize.Height}{Environment.NewLine}" +
                    $"Game size: {numRow.Value * cellSize}x{numCol.Value * cellSize}"
                );
                return false;
            }
            return true;
        }

        /// <summary>
        /// Starts the game through <c>MainWindow</c> with the provided arguments
        /// </summary>
        private void BtnStartClicked(object sender, EventArgs e)
        {
            if (!ValidateDimensions())
            {
                return;
            }

            mainWindow = new MainWindow((int)numRow.Value, (int)numCol.Value, (int)numFood.Value, (int)numTraps.Value, cellSize);
            mainWindow.Show();
            mainWindow.QuitGameEvent += HandleGameQuitEvent;
            Hide();
        }

        /// <summary>
        /// Writes the recieved score to the scores file and adds the score to the scoreboard
        /// </summary>
        /// <param name="e">Object containing score</param>
        private void HandleGameQuitEvent(object sender, QuitEventArgs e)
        {
            File.AppendAllText(scoresPath, e.PlayerScore + Environment.NewLine);
            mainWindow.Close();
            Show();
            // Add score to scoreboard
            listScoreView.Items.Add(e.PlayerScore.ToString());
        }

        /// <summary>
        /// Flips the sorting when the column of the scoreboard is clicked
        /// </summary>
        private void ScoreColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listNumSort.OrderSort == SortOrder.Ascending)
            {
                listNumSort.OrderSort = SortOrder.Descending;
            }
            else
            {
                listNumSort.OrderSort = SortOrder.Ascending;
            }
            // Resort after flipping sorting order
            listScoreView.Sort();
        }

        /// <summary>
        /// Fills game arguments with random reasonable values
        /// </summary>
        private void RandomClicked(object sender, EventArgs e)
        {
            Random random = new Random();
            // Randomise all values for generation

            // Randomise grid size first to prevent having too many mines / traps
            int randCols = random.Next(5, 30);
            int randRows = random.Next(5, 30);

            int totalCells = randRows * randCols;

            int randFood = random.Next(1, totalCells / 6);
            int randTraps = random.Next(1, (totalCells - randFood) / 6);

            numCol.Value = randCols;
            numRow.Value = randRows;
            numFood.Value = randFood;
            numTraps.Value = randTraps;
        }

        /// <summary>
        /// Loads the settings set in <c>settings.conf</c>
        /// </summary>
        private void LoadSettingsClicked(object sender, EventArgs e)
        {
            settings.ReadSettingsFile();
            AssignSettings();
        }

        /// <summary>
        /// Saves the current settings to <c>settings.conf</c>
        /// </summary>
        private void SaveSettingsClick(object sender, EventArgs e)
        {
            if (!ValidateDimensions())
            {
                return;
            }

            settings.NumRows = (int)numRow.Value;
            settings.NumCols = (int)numCol.Value;
            settings.NumFood = (int)numFood.Value;
            settings.NumTraps = (int)numTraps.Value;
            settings.SaveSettings();
        }
    }
}
