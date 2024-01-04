
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

        private void scoreColumnClick(object sender, ColumnClickEventArgs e)
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
    }
}
