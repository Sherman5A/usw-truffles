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
            listView1 = new ListView();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTraps).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(39, 190);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(328, 192);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClicked;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(418, 190);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(328, 192);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += BtnQuitClicked;
            // 
            // numCol
            // 
            numCol.Location = new Point(163, 69);
            numCol.Name = "numCol";
            numCol.Size = new Size(86, 23);
            numCol.TabIndex = 2;
            // 
            // numRow
            // 
            numRow.Location = new Point(163, 98);
            numRow.Name = "numRow";
            numRow.Size = new Size(86, 23);
            numRow.TabIndex = 3;
            // 
            // lblNumCol
            // 
            lblNumCol.AutoSize = true;
            lblNumCol.Location = new Point(39, 71);
            lblNumCol.Name = "lblNumCol";
            lblNumCol.Size = new Size(114, 15);
            lblNumCol.TabIndex = 4;
            lblNumCol.Text = "Number of columns";
            lblNumCol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumRow
            // 
            lblNumRow.AutoSize = true;
            lblNumRow.Location = new Point(60, 100);
            lblNumRow.Name = "lblNumRow";
            lblNumRow.Size = new Size(93, 15);
            lblNumRow.TabIndex = 5;
            lblNumRow.Text = "Number of rows";
            lblNumRow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumFood
            // 
            lblNumFood.AutoSize = true;
            lblNumFood.Location = new Point(60, 129);
            lblNumFood.Name = "lblNumFood";
            lblNumFood.Size = new Size(93, 15);
            lblNumFood.TabIndex = 6;
            lblNumFood.Text = "Amount of food";
            lblNumFood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumTraps
            // 
            lblNumTraps.AutoSize = true;
            lblNumTraps.Location = new Point(59, 158);
            lblNumTraps.Name = "lblNumTraps";
            lblNumTraps.Size = new Size(94, 15);
            lblNumTraps.TabIndex = 7;
            lblNumTraps.Text = "Number of traps";
            lblNumTraps.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numFood
            // 
            numFood.Location = new Point(163, 127);
            numFood.Name = "numFood";
            numFood.Size = new Size(86, 23);
            numFood.TabIndex = 8;
            // 
            // numTraps
            // 
            numTraps.Location = new Point(163, 156);
            numTraps.Name = "numTraps";
            numTraps.Size = new Size(86, 23);
            numTraps.TabIndex = 9;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(271, 127);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(96, 52);
            btnRandomise.TabIndex = 10;
            btnRandomise.Text = "Randomise";
            btnRandomise.UseVisualStyleBackColor = true;
            // 
            // btnDefaultValues
            // 
            btnDefaultValues.Location = new Point(271, 69);
            btnDefaultValues.Name = "btnDefaultValues";
            btnDefaultValues.Size = new Size(96, 49);
            btnDefaultValues.TabIndex = 11;
            btnDefaultValues.Text = "Default values";
            btnDefaultValues.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(418, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(328, 108);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(288, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 47);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Food Game";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(listView1);
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
        private ListView listView1;
        private Label lblTitle;
    }
}