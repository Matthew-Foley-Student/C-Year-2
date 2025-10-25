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
            SuspendLayout();
            // 
            // lblWinOrLose
            // 
            lblWinOrLose.AutoSize = true;
            lblWinOrLose.Font = new Font("Century", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWinOrLose.Location = new Point(315, 192);
            lblWinOrLose.Name = "lblWinOrLose";
            lblWinOrLose.Size = new Size(322, 116);
            lblWinOrLose.TabIndex = 0;
            lblWinOrLose.Text = "label1";
            // 
            // frmWinOrLose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 581);
            Controls.Add(lblWinOrLose);
            Name = "frmWinOrLose";
            Text = "Win_Or_Lose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWinOrLose;
    }
}