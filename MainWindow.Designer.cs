namespace Truffles
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
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.Cursor = Cursors.Hand;
            btnUp.Location = new Point(102, 160);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(50, 50);
            btnUp.TabIndex = 0;
            btnUp.Tag = "up";
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += MovementButtonClicked;
            // 
            // btnRight
            // 
            btnRight.Cursor = Cursors.Hand;
            btnRight.Location = new Point(164, 213);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(50, 50);
            btnRight.TabIndex = 1;
            btnRight.Tag = "right";
            btnRight.Text = "Right";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += MovementButtonClicked;
            // 
            // btnDown
            // 
            btnDown.Cursor = Cursors.Hand;
            btnDown.Location = new Point(102, 266);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(50, 50);
            btnDown.TabIndex = 2;
            btnDown.Tag = "down";
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += MovementButtonClicked;
            // 
            // btnLeft
            // 
            btnLeft.Cursor = Cursors.Hand;
            btnLeft.Location = new Point(40, 213);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(50, 50);
            btnLeft.TabIndex = 3;
            btnLeft.Tag = "left";
            btnLeft.Text = "Left";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += MovementButtonClicked;
            // 
            // lblRisk
            // 
            lblRisk.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRisk.Location = new Point(111, 338);
            lblRisk.Name = "lblRisk";
            lblRisk.Size = new Size(65, 37);
            lblRisk.TabIndex = 4;
            lblRisk.Text = "0";
            lblRisk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(111, 418);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(103, 37);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            lblScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRiskTitle
            // 
            lblRiskTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblRiskTitle.Location = new Point(31, 338);
            lblRiskTitle.Name = "lblRiskTitle";
            lblRiskTitle.Size = new Size(86, 37);
            lblRiskTitle.TabIndex = 6;
            lblRiskTitle.Text = "Risk:";
            lblRiskTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoreTitle.Location = new Point(22, 418);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(95, 37);
            lblScoreTitle.TabIndex = 7;
            lblScoreTitle.Text = "Score:";
            lblScoreTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 665);
            Controls.Add(lblScoreTitle);
            Controls.Add(lblRiskTitle);
            Controls.Add(lblScore);
            Controls.Add(lblRisk);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnRight);
            Controls.Add(btnUp);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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
    }
}
