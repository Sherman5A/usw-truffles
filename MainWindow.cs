using System.Diagnostics;

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

        public Panel gameSpace = new Panel();

        private void Form1_Load(object sender, EventArgs e)
        {
            setupMainWindow();
            setupGameSpace();
            addLabel(6, 8);
        }

        private void addLabel(int labelColumn, int labelRow)
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

        private void setupMainWindow()
        {
            // Size form to accommodate size and number of grid cells and control area
            Size = new Size(numCols * cellSize + xSpaceShift, numRows * cellSize + ySpaceShift);
        }

        private void setupGameSpace()
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
