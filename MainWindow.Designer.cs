﻿namespace USWGame
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
            components = new System.ComponentModel.Container();
            btnUp = new Button();
            btnRight = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            lblRisk = new Label();
            lblScore = new Label();
            lblRiskTitle = new Label();
            lblScoreTitle = new Label();
            button1 = new Button();
            lblRoundsTitle = new Label();
            lblRounds = new Label();
            revealTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.PeachPuff;
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
            btnRight.BackColor = Color.PeachPuff;
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
            btnDown.BackColor = Color.PeachPuff;
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
            btnLeft.BackColor = Color.PeachPuff;
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
            lblRisk.BackColor = Color.Transparent;
            lblRisk.Font = new Font("Centaur", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblRisk.ForeColor = Color.WhiteSmoke;
            lblRisk.Location = new Point(150, 445);
            lblRisk.Name = "lblRisk";
            lblRisk.Size = new Size(107, 49);
            lblRisk.TabIndex = 4;
            lblRisk.Text = "0";
            lblRisk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Centaur", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.WhiteSmoke;
            lblScore.Location = new Point(149, 509);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(107, 49);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            lblScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRiskTitle
            // 
            lblRiskTitle.BackColor = Color.Transparent;
            lblRiskTitle.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblRiskTitle.ForeColor = Color.WhiteSmoke;
            lblRiskTitle.Location = new Point(47, 445);
            lblRiskTitle.Name = "lblRiskTitle";
            lblRiskTitle.Size = new Size(97, 49);
            lblRiskTitle.TabIndex = 6;
            lblRiskTitle.Text = "Risk:";
            lblRiskTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.BackColor = Color.Transparent;
            lblScoreTitle.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoreTitle.ForeColor = Color.WhiteSmoke;
            lblScoreTitle.Location = new Point(33, 509);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(111, 49);
            lblScoreTitle.TabIndex = 7;
            lblScoreTitle.Text = "Score:";
            lblScoreTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(14, 15);
            button1.Name = "button1";
            button1.Size = new Size(271, 65);
            button1.TabIndex = 8;
            button1.Text = "Exit Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += QuitClicked;
            // 
            // lblRoundsTitle
            // 
            lblRoundsTitle.BackColor = Color.Transparent;
            lblRoundsTitle.Font = new Font("High Tower Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoundsTitle.ForeColor = Color.WhiteSmoke;
            lblRoundsTitle.Location = new Point(0, 571);
            lblRoundsTitle.Name = "lblRoundsTitle";
            lblRoundsTitle.Size = new Size(144, 49);
            lblRoundsTitle.TabIndex = 9;
            lblRoundsTitle.Text = "Rounds:";
            lblRoundsTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRounds
            // 
            lblRounds.BackColor = Color.Transparent;
            lblRounds.Font = new Font("Centaur", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblRounds.ForeColor = Color.WhiteSmoke;
            lblRounds.Location = new Point(149, 571);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new Size(107, 49);
            lblRounds.TabIndex = 10;
            lblRounds.Text = "0";
            lblRounds.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // revealTimer
            // 
            revealTimer.Interval = 1000;
            revealTimer.Tick += RevealDurationComplete;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = Properties.Resources.controlBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 1021);
            Controls.Add(lblRounds);
            Controls.Add(lblRoundsTitle);
            Controls.Add(button1);
            Controls.Add(lblScoreTitle);
            Controls.Add(lblRiskTitle);
            Controls.Add(lblScore);
            Controls.Add(lblRisk);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnRight);
            Controls.Add(btnUp);
            DoubleBuffered = true;
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
        private Label lblRoundsTitle;
        private Label lblRounds;
        private System.Windows.Forms.Timer revealTimer;
    }
}
