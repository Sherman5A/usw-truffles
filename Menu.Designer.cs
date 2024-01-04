namespace Truffles
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
            ((System.ComponentModel.ISupportInitialize)numCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTraps).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(45, 253);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(375, 256);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClicked;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(478, 253);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(375, 256);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += BtnQuitClicked;
            // 
            // numCol
            // 
            numCol.Location = new Point(186, 92);
            numCol.Margin = new Padding(3, 4, 3, 4);
            numCol.Name = "numCol";
            numCol.Size = new Size(98, 27);
            numCol.TabIndex = 2;
            // 
            // numRow
            // 
            numRow.Location = new Point(186, 131);
            numRow.Margin = new Padding(3, 4, 3, 4);
            numRow.Name = "numRow";
            numRow.Size = new Size(98, 27);
            numRow.TabIndex = 3;
            // 
            // lblNumCol
            // 
            lblNumCol.AutoSize = true;
            lblNumCol.Location = new Point(45, 95);
            lblNumCol.Name = "lblNumCol";
            lblNumCol.Size = new Size(140, 20);
            lblNumCol.TabIndex = 4;
            lblNumCol.Text = "Number of columns";
            lblNumCol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumRow
            // 
            lblNumRow.AutoSize = true;
            lblNumRow.Location = new Point(69, 133);
            lblNumRow.Name = "lblNumRow";
            lblNumRow.Size = new Size(116, 20);
            lblNumRow.TabIndex = 5;
            lblNumRow.Text = "Number of rows";
            lblNumRow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumFood
            // 
            lblNumFood.AutoSize = true;
            lblNumFood.Location = new Point(69, 172);
            lblNumFood.Name = "lblNumFood";
            lblNumFood.Size = new Size(116, 20);
            lblNumFood.TabIndex = 6;
            lblNumFood.Text = "Amount of food";
            lblNumFood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumTraps
            // 
            lblNumTraps.AutoSize = true;
            lblNumTraps.Location = new Point(67, 211);
            lblNumTraps.Name = "lblNumTraps";
            lblNumTraps.Size = new Size(118, 20);
            lblNumTraps.TabIndex = 7;
            lblNumTraps.Text = "Number of traps";
            lblNumTraps.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numFood
            // 
            numFood.Location = new Point(186, 169);
            numFood.Margin = new Padding(3, 4, 3, 4);
            numFood.Name = "numFood";
            numFood.Size = new Size(98, 27);
            numFood.TabIndex = 8;
            // 
            // numTraps
            // 
            numTraps.Location = new Point(186, 208);
            numTraps.Margin = new Padding(3, 4, 3, 4);
            numTraps.Name = "numTraps";
            numTraps.Size = new Size(98, 27);
            numTraps.TabIndex = 9;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(310, 169);
            btnRandomise.Margin = new Padding(3, 4, 3, 4);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(110, 69);
            btnRandomise.TabIndex = 10;
            btnRandomise.Text = "Randomise";
            btnRandomise.UseVisualStyleBackColor = true;
            // 
            // btnDefaultValues
            // 
            btnDefaultValues.Location = new Point(310, 92);
            btnDefaultValues.Margin = new Padding(3, 4, 3, 4);
            btnDefaultValues.Name = "btnDefaultValues";
            btnDefaultValues.Size = new Size(110, 65);
            btnDefaultValues.TabIndex = 11;
            btnDefaultValues.Text = "Default values";
            btnDefaultValues.UseVisualStyleBackColor = true;
            // 
            // listScoreView
            // 
            listScoreView.Columns.AddRange(new ColumnHeader[] { colScores });
            listScoreView.Location = new Point(478, 95);
            listScoreView.Margin = new Padding(3, 4, 3, 4);
            listScoreView.Name = "listScoreView";
            listScoreView.Size = new Size(374, 143);
            listScoreView.TabIndex = 12;
            listScoreView.UseCompatibleStateImageBehavior = false;
            listScoreView.View = View.Details;
            listScoreView.ColumnClick += scoreColumnClick;
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
            lblTitle.Location = new Point(329, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 60);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Food Game";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
    }
}