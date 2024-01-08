namespace USWGame
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnQuit = new Button();
            numCol = new NumericUpDown();
            numRow = new NumericUpDown();
            lblNumCol = new Label();
            lblNumRow = new Label();
            lblNumFood = new Label();
            lblNumTraps = new Label();
            numFood = new NumericUpDown();
            numTraps = new NumericUpDown();
            btnRandomise = new Button();
            btnDefaultValues = new Button();
            listScoreView = new ListView();
            colScores = new ColumnHeader();
            lblTitle = new Label();
            btnSaveSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)numCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTraps).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSalmon;
            btnStart.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(25, 253);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(410, 256);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStartClicked;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.DarkSalmon;
            btnQuit.Font = new Font("High Tower Text", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.Location = new Point(479, 253);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(410, 256);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += BtnQuitClicked;
            // 
            // numCol
            // 
            numCol.Location = new Point(167, 132);
            numCol.Margin = new Padding(3, 4, 3, 4);
            numCol.Name = "numCol";
            numCol.Size = new Size(97, 27);
            numCol.TabIndex = 2;
            // 
            // numRow
            // 
            numRow.Location = new Point(167, 93);
            numRow.Margin = new Padding(3, 4, 3, 4);
            numRow.Name = "numRow";
            numRow.Size = new Size(97, 27);
            numRow.TabIndex = 3;
            // 
            // lblNumCol
            // 
            lblNumCol.AutoSize = true;
            lblNumCol.BackColor = Color.Transparent;
            lblNumCol.Location = new Point(25, 135);
            lblNumCol.Name = "lblNumCol";
            lblNumCol.Size = new Size(140, 20);
            lblNumCol.TabIndex = 4;
            lblNumCol.Text = "Number of columns";
            lblNumCol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumRow
            // 
            lblNumRow.AutoSize = true;
            lblNumRow.BackColor = Color.Transparent;
            lblNumRow.Location = new Point(50, 95);
            lblNumRow.Name = "lblNumRow";
            lblNumRow.Size = new Size(116, 20);
            lblNumRow.TabIndex = 5;
            lblNumRow.Text = "Number of rows";
            lblNumRow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumFood
            // 
            lblNumFood.AutoSize = true;
            lblNumFood.BackColor = Color.Transparent;
            lblNumFood.Location = new Point(49, 172);
            lblNumFood.Name = "lblNumFood";
            lblNumFood.Size = new Size(116, 20);
            lblNumFood.TabIndex = 6;
            lblNumFood.Text = "Amount of food";
            lblNumFood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumTraps
            // 
            lblNumTraps.AutoSize = true;
            lblNumTraps.BackColor = Color.Transparent;
            lblNumTraps.Location = new Point(48, 211);
            lblNumTraps.Name = "lblNumTraps";
            lblNumTraps.Size = new Size(118, 20);
            lblNumTraps.TabIndex = 7;
            lblNumTraps.Text = "Number of traps";
            lblNumTraps.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numFood
            // 
            numFood.Location = new Point(167, 169);
            numFood.Margin = new Padding(3, 4, 3, 4);
            numFood.Name = "numFood";
            numFood.Size = new Size(97, 27);
            numFood.TabIndex = 8;
            // 
            // numTraps
            // 
            numTraps.Location = new Point(167, 208);
            numTraps.Margin = new Padding(3, 4, 3, 4);
            numTraps.Name = "numTraps";
            numTraps.Size = new Size(97, 27);
            numTraps.TabIndex = 9;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(281, 193);
            btnRandomise.Margin = new Padding(3, 4, 3, 4);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(154, 40);
            btnRandomise.TabIndex = 10;
            btnRandomise.Text = "Randomise settings";
            btnRandomise.UseVisualStyleBackColor = true;
            btnRandomise.Click += RandomClicked;
            // 
            // btnDefaultValues
            // 
            btnDefaultValues.Location = new Point(281, 93);
            btnDefaultValues.Margin = new Padding(3, 4, 3, 4);
            btnDefaultValues.Name = "btnDefaultValues";
            btnDefaultValues.Size = new Size(154, 40);
            btnDefaultValues.TabIndex = 11;
            btnDefaultValues.Text = "Load settings";
            btnDefaultValues.UseVisualStyleBackColor = true;
            btnDefaultValues.Click += DefaultClicked;
            // 
            // listScoreView
            // 
            listScoreView.Columns.AddRange(new ColumnHeader[] { colScores });
            listScoreView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listScoreView.Location = new Point(479, 95);
            listScoreView.Margin = new Padding(3, 4, 3, 4);
            listScoreView.Name = "listScoreView";
            listScoreView.Size = new Size(411, 143);
            listScoreView.TabIndex = 12;
            listScoreView.UseCompatibleStateImageBehavior = false;
            listScoreView.View = View.Details;
            listScoreView.ColumnClick += ScoreColumnClick;
            // 
            // colScores
            // 
            colScores.Text = "Best Scores";
            colScores.Width = 300;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(299, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 71);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Food Game";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(281, 141);
            btnSaveSettings.Margin = new Padding(3, 4, 3, 4);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(154, 40);
            btnSaveSettings.TabIndex = 14;
            btnSaveSettings.Text = "Save settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += SaveSettingsClick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.settings_background;
            ClientSize = new Size(913, 600);
            Controls.Add(btnSaveSettings);
            Controls.Add(lblTitle);
            Controls.Add(listScoreView);
            Controls.Add(btnDefaultValues);
            Controls.Add(btnRandomise);
            Controls.Add(numTraps);
            Controls.Add(numFood);
            Controls.Add(lblNumTraps);
            Controls.Add(lblNumFood);
            Controls.Add(lblNumRow);
            Controls.Add(lblNumCol);
            Controls.Add(numRow);
            Controls.Add(numCol);
            Controls.Add(btnQuit);
            Controls.Add(btnStart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Main Menu";
            Load += MenuLoad;
            ((System.ComponentModel.ISupportInitialize)numCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTraps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnQuit;
        private NumericUpDown numCol;
        private NumericUpDown numRow;
        private Label lblNumCol;
        private Label lblNumRow;
        private Label lblNumFood;
        private Label lblNumTraps;
        private NumericUpDown numFood;
        private NumericUpDown numTraps;
        private Button btnRandomise;
        private Button btnDefaultValues;
        private ListView listScoreView;
        private Label lblTitle;
        private ColumnHeader colScores;
        private Button btnSaveSettings;
    }
}