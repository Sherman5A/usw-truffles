namespace USWGame
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUp = new Button();
            btnRight = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            lblRisk = new Label();
            lblScore = new Label();
            lblRiskTitle = new Label();
            lblScoreTitle = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.Thistle;
            btnUp.Cursor = Cursors.Hand;
            btnUp.Location = new Point(117, 213);
            btnUp.Margin = new Padding(3, 4, 3, 4);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(57, 67);
            btnUp.TabIndex = 0;
            btnUp.Tag = "up";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += MovementButtonClicked;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.Thistle;
            btnRight.Cursor = Cursors.Hand;
            btnRight.Location = new Point(187, 284);
            btnRight.Margin = new Padding(3, 4, 3, 4);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(57, 67);
            btnRight.TabIndex = 1;
            btnRight.Tag = "right";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += MovementButtonClicked;
            // 
            // btnDown
            // 
            btnDown.BackColor = Color.Thistle;
            btnDown.Cursor = Cursors.Hand;
            btnDown.Location = new Point(117, 355);
            btnDown.Margin = new Padding(3, 4, 3, 4);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(57, 67);
            btnDown.TabIndex = 2;
            btnDown.Tag = "down";
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += MovementButtonClicked;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.Thistle;
            btnLeft.Cursor = Cursors.Hand;
            btnLeft.Location = new Point(46, 284);
            btnLeft.Margin = new Padding(3, 4, 3, 4);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(57, 67);
            btnLeft.TabIndex = 3;
            btnLeft.Tag = "left";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += MovementButtonClicked;
            // 
            // lblRisk
            // 
            lblRisk.Font = new Font("Centaur", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblRisk.Location = new Point(127, 451);
            lblRisk.Name = "lblRisk";
            lblRisk.Size = new Size(118, 49);
            lblRisk.TabIndex = 4;
            lblRisk.Text = "0";
            lblRisk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Centaur", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(127, 557);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(118, 49);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            lblScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRiskTitle
            // 
            lblRiskTitle.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblRiskTitle.Location = new Point(35, 451);
            lblRiskTitle.Name = "lblRiskTitle";
            lblRiskTitle.Size = new Size(98, 49);
            lblRiskTitle.TabIndex = 6;
            lblRiskTitle.Text = "Risk:";
            lblRiskTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoreTitle.Location = new Point(12, 557);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(122, 49);
            lblScoreTitle.TabIndex = 7;
            lblScoreTitle.Text = "Score:";
            lblScoreTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("High Tower Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(245, 65);
            button1.TabIndex = 8;
            button1.Text = "Exit Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += QuitClicked;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1098, 1021);
            Controls.Add(button1);
            Controls.Add(lblScoreTitle);
            Controls.Add(lblRiskTitle);
            Controls.Add(lblScore);
            Controls.Add(lblRisk);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnRight);
            Controls.Add(btnUp);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "Truffles";
            Load += MainWindowLoad;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUp;
        private Button btnRight;
        private Button btnDown;
        private Button btnLeft;
        private Label lblRisk;
        private Label lblScore;
        private Label lblRiskTitle;
        private Label lblScoreTitle;
        private Button button1;
    }
}
