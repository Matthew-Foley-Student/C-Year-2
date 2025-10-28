namespace MineSweeperGUI
{
    partial class frmWinOrLose
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
            lblWinOrLose = new Label();
            label1 = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // lblWinOrLose
            // 
            lblWinOrLose.AutoSize = true;
            lblWinOrLose.Dock = DockStyle.Top;
            lblWinOrLose.Font = new Font("Century", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWinOrLose.Location = new Point(0, 0);
            lblWinOrLose.Name = "lblWinOrLose";
            lblWinOrLose.Size = new Size(322, 116);
            lblWinOrLose.TabIndex = 0;
            lblWinOrLose.Text = "label1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(633, 661);
            label1.Name = "label1";
            label1.Size = new Size(115, 45);
            label1.TabIndex = 1;
            label1.Text = "Score :";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Bottom;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(742, 667);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(96, 37);
            lblScore.TabIndex = 2;
            lblScore.Text = "label2";
            // 
            // frmWinOrLose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 715);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(lblWinOrLose);
            Name = "frmWinOrLose";
            Text = "Win_Or_Lose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWinOrLose;
        private Label label1;
        private Label lblScore;
    }
}