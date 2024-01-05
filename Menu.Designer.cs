﻿namespace USWGame
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
            btnStart.Location = new Point(32, 316);
            btnStart.Margin = new Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(513, 320);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClicked;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(598, 316);
            btnQuit.Margin = new Padding(4, 5, 4, 5);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(513, 320);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += BtnQuitClicked;
            // 
            // numCol
            // 
            numCol.Location = new Point(208, 165);
            numCol.Margin = new Padding(4, 5, 4, 5);
            numCol.Name = "numCol";
            numCol.Size = new Size(122, 31);
            numCol.TabIndex = 2;
            // 
            // numRow
            // 
            numRow.Location = new Point(209, 117);
            numRow.Margin = new Padding(4, 5, 4, 5);
            numRow.Name = "numRow";
            numRow.Size = new Size(122, 31);
            numRow.TabIndex = 3;
            // 
            // lblNumCol
            // 
            lblNumCol.AutoSize = true;
            lblNumCol.Location = new Point(32, 169);
            lblNumCol.Margin = new Padding(4, 0, 4, 0);
            lblNumCol.Name = "lblNumCol";
            lblNumCol.Size = new Size(171, 25);
            lblNumCol.TabIndex = 4;
            lblNumCol.Text = "Number of columns";
            lblNumCol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumRow
            // 
            lblNumRow.AutoSize = true;
            lblNumRow.Location = new Point(63, 119);
            lblNumRow.Margin = new Padding(4, 0, 4, 0);
            lblNumRow.Name = "lblNumRow";
            lblNumRow.Size = new Size(142, 25);
            lblNumRow.TabIndex = 5;
            lblNumRow.Text = "Number of rows";
            lblNumRow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumFood
            // 
            lblNumFood.AutoSize = true;
            lblNumFood.Location = new Point(62, 215);
            lblNumFood.Margin = new Padding(4, 0, 4, 0);
            lblNumFood.Name = "lblNumFood";
            lblNumFood.Size = new Size(143, 25);
            lblNumFood.TabIndex = 6;
            lblNumFood.Text = "Amount of food";
            lblNumFood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumTraps
            // 
            lblNumTraps.AutoSize = true;
            lblNumTraps.Location = new Point(60, 264);
            lblNumTraps.Margin = new Padding(4, 0, 4, 0);
            lblNumTraps.Name = "lblNumTraps";
            lblNumTraps.Size = new Size(144, 25);
            lblNumTraps.TabIndex = 7;
            lblNumTraps.Text = "Number of traps";
            lblNumTraps.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numFood
            // 
            numFood.Location = new Point(208, 211);
            numFood.Margin = new Padding(4, 5, 4, 5);
            numFood.Name = "numFood";
            numFood.Size = new Size(122, 31);
            numFood.TabIndex = 8;
            // 
            // numTraps
            // 
            numTraps.Location = new Point(208, 260);
            numTraps.Margin = new Padding(4, 5, 4, 5);
            numTraps.Name = "numTraps";
            numTraps.Size = new Size(122, 31);
            numTraps.TabIndex = 9;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(352, 241);
            btnRandomise.Margin = new Padding(4, 5, 4, 5);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(193, 50);
            btnRandomise.TabIndex = 10;
            btnRandomise.Text = "Randomise settings";
            btnRandomise.UseVisualStyleBackColor = true;
            btnRandomise.Click += RandomClicked;
            // 
            // btnDefaultValues
            // 
            btnDefaultValues.Location = new Point(352, 117);
            btnDefaultValues.Margin = new Padding(4, 5, 4, 5);
            btnDefaultValues.Name = "btnDefaultValues";
            btnDefaultValues.Size = new Size(193, 50);
            btnDefaultValues.TabIndex = 11;
            btnDefaultValues.Text = "Load settings";
            btnDefaultValues.UseVisualStyleBackColor = true;
            btnDefaultValues.Click += DefaultClicked;
            // 
            // listScoreView
            // 
            listScoreView.Columns.AddRange(new ColumnHeader[] { colScores });
            listScoreView.Location = new Point(598, 119);
            listScoreView.Margin = new Padding(4, 5, 4, 5);
            listScoreView.Name = "listScoreView";
            listScoreView.Size = new Size(513, 178);
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
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(411, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 71);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Food Game";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(352, 177);
            btnSaveSettings.Margin = new Padding(4, 5, 4, 5);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(193, 50);
            btnSaveSettings.TabIndex = 14;
            btnSaveSettings.Text = "Save settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += SaveSettingsClick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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