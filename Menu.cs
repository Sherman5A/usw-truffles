using System.Diagnostics;

namespace Truffles
{
    public partial class Menu : Form
    {
        MainWindow mainWindow;


        public Menu()
        {
            InitializeComponent();
        }

        private void MenuLoad(object sender, EventArgs e)
        {
            Debug.WriteLine(Application.OpenForms.ToString());
        }

        private void BtnQuitClicked(object sender, EventArgs e)
        {

        }

        private void BtnStartClicked(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void HandleGameLossEvent(object sender, EventArgs e)
        {
            mainWindow.Close();
            Show();
        }
    }
}
