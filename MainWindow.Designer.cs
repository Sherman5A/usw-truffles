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
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.Cursor = Cursors.Hand;
            btnUp.Location = new Point(102, 160);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(50, 50);
            btnUp.TabIndex = 0;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUpClick;
            // 
            // btnRight
            // 
            btnRight.Cursor = Cursors.Hand;
            btnRight.Location = new Point(164, 213);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(50, 50);
            btnRight.TabIndex = 1;
            btnRight.Text = "Right";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRightClick;
            // 
            // btnDown
            // 
            btnDown.Cursor = Cursors.Hand;
            btnDown.Location = new Point(102, 266);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(50, 50);
            btnDown.TabIndex = 2;
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDownClick;
            // 
            // btnLeft
            // 
            btnLeft.Cursor = Cursors.Hand;
            btnLeft.Location = new Point(40, 213);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(50, 50);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "Left";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeftClick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 665);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnRight);
            Controls.Add(btnUp);
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
    }
}
