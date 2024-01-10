
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

        private void MenuLoad(object sender, EventArgs e)
        {
            LoadScores();
            LoadSettings();
        }

        private void LoadSettings()
        {
            numRow.Value = settings.NumRows;
            numCol.Value = settings.NumCols;
            numTraps.Value = settings.NumTraps;
            numFood.Value = settings.NumFood;
        }

        private void LoadScores()
        {
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
            listScoreView.Sorting = SortOrder.Descending;
            listScoreView.ListViewItemSorter = listNumSort;
            scores.ForEach(s =>
            {
                listScoreView.Items.Add(s);
            });
            listScoreView.Sort();
        }

        private void BtnQuitClicked(object sender, EventArgs e)
        {
            if (mainWindow is not null)
            {
                mainWindow.Close();
            }
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

        private bool ValidateItems()
        {
            return true;
        }

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

        private void HandleGameQuitEvent(object sender, QuitEventArgs e)
        {
            File.AppendAllText(scoresPath, e.PlayerScore + Environment.NewLine);
            mainWindow.Close();
            Show();
            listScoreView.Items.Add(e.PlayerScore.ToString());
        }

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
            listScoreView.Sort();
        }

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

        private void DefaultClicked(object sender, EventArgs e)
        {
            settings.ReadSettingsFile();
            LoadSettings();
        }

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
