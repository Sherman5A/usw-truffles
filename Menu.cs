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
            Debug.WriteLine(e.PlayerScore);
            mainWindow.Close();
            Show();
        }
    }
}
