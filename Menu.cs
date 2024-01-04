
namespace Truffles
{
    public partial class Menu : Form
    {
        private string filePath = "scores.txt";
        private MainWindow mainWindow;
        private List<string> scores;
        private ListViewNumberSort listNumSort;

        public Menu()
        {
            InitializeComponent();
            listNumSort = new ListViewNumberSort()
            {
                OrderSort = SortOrder.Descending,
                SortColumn = 0,
            };
        }

        private void MenuLoad(object sender, EventArgs e)
        {
            scores = File.ReadAllLines(filePath).ToList();
            listScoreView.View = View.Details;
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

        private void BtnStartClicked(object sender, EventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.QuitGameEvent += HandleGameQuitEvent;
            Hide();
        }

        private void HandleGameQuitEvent(object sender, QuitEventArgs e)
        {
            File.AppendAllText(filePath, e.PlayerScore + Environment.NewLine);
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

        private void RandomiseClicked(object sender, EventArgs e)
        {
            Random random = new Random();
            // Randomise all values for generation

            // Randomise grid size first to prevent having too many mines / traps
            int randCols = random.Next(5, 30);
            int randRows = random.Next(5, 30);

            int totalCells = randRows * randCols;

            int randFood = random.Next(1, totalCells / 6);
            int randTraps = random.Next(1, (totalCells - randFood) / 6);

            numCol.Value= randCols;
            numRow.Value= randRows;
            numFood.Value= randFood;
            numTraps.Value= randTraps;
        }
    }
}
