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
            btnStart.BackColor = Color.PeachPuff;
            btnStart.Font = new Font("High Tower Text", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(22, 190);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(359, 192);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStartClicked;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.PeachPuff;
            btnQuit.Font = new Font("High Tower Text", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.Location = new Point(419, 190);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(359, 192);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += BtnQuitClicked;
            // 
            // numCol
            // 
            numCol.Location = new Point(146, 99);
            numCol.Name = "numCol";
            numCol.Size = new Size(85, 23);
            numCol.TabIndex = 2;
            // 
            // numRow
            // 
            numRow.Location = new Point(146, 70);
            numRow.Name = "numRow";
            numRow.Size = new Size(85, 23);
            numRow.TabIndex = 3;
            // 
            // lblNumCol
            // 
            lblNumCol.AutoSize = true;
            lblNumCol.BackColor = Color.Transparent;
            lblNumCol.ForeColor = Color.WhiteSmoke;
            lblNumCol.Location = new Point(22, 101);
            lblNumCol.Name = "lblNumCol";
            lblNumCol.Size = new Size(114, 15);
            lblNumCol.TabIndex = 4;
            lblNumCol.Text = "Number of columns";
            lblNumCol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumRow
            // 
            lblNumRow.AutoSize = true;
            lblNumRow.BackColor = Color.Transparent;
            lblNumRow.ForeColor = Color.WhiteSmoke;
            lblNumRow.Location = new Point(44, 71);
            lblNumRow.Name = "lblNumRow";
            lblNumRow.Size = new Size(93, 15);
            lblNumRow.TabIndex = 5;
            lblNumRow.Text = "Number of rows";
            lblNumRow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumFood
            // 
            lblNumFood.AutoSize = true;
            lblNumFood.BackColor = Color.Transparent;
            lblNumFood.ForeColor = Color.WhiteSmoke;
            lblNumFood.Location = new Point(43, 129);
            lblNumFood.Name = "lblNumFood";
            lblNumFood.Size = new Size(93, 15);
            lblNumFood.TabIndex = 6;
            lblNumFood.Text = "Amount of food";
            lblNumFood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumTraps
            // 
            lblNumTraps.AutoSize = true;
            lblNumTraps.BackColor = Color.Transparent;
            lblNumTraps.ForeColor = Color.WhiteSmoke;
            lblNumTraps.Location = new Point(42, 158);
            lblNumTraps.Name = "lblNumTraps";
            lblNumTraps.Size = new Size(94, 15);
            lblNumTraps.TabIndex = 7;
            lblNumTraps.Text = "Number of traps";
            lblNumTraps.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numFood
            // 
            numFood.Location = new Point(146, 127);
            numFood.Name = "numFood";
            numFood.Size = new Size(85, 23);
            numFood.TabIndex = 8;
            // 
            // numTraps
            // 
            numTraps.Location = new Point(146, 156);
            numTraps.Name = "numTraps";
            numTraps.Size = new Size(85, 23);
            numTraps.TabIndex = 9;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(246, 145);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(135, 30);
            btnRandomise.TabIndex = 10;
            btnRandomise.Text = "Randomise settings";
            btnRandomise.UseVisualStyleBackColor = true;
            btnRandomise.Click += RandomClicked;
            // 
            // btnDefaultValues
            // 
            btnDefaultValues.Location = new Point(246, 70);
            btnDefaultValues.Name = "btnDefaultValues";
            btnDefaultValues.Size = new Size(135, 30);
            btnDefaultValues.TabIndex = 11;
            btnDefaultValues.Text = "Load settings";
            btnDefaultValues.UseVisualStyleBackColor = true;
            btnDefaultValues.Click += LoadSettingsClicked;
            // 
            // listScoreView
            // 
            listScoreView.Columns.AddRange(new ColumnHeader[] { colScores });
            listScoreView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listScoreView.Location = new Point(419, 71);
            listScoreView.Name = "listScoreView";
            listScoreView.Size = new Size(360, 108);
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
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(262, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 57);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Food Game";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(246, 106);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(135, 30);
            btnSaveSettings.TabIndex = 14;
            btnSaveSettings.Text = "Save settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += SaveSettingsClick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
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