namespace WhackTheMole
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
            lblCondition = new Label();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCondition.Location = new Point(232, 153);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(338, 89);
            lblCondition.TabIndex = 0;
            lblCondition.Text = "Text Here";
            // 
            // frmWinOrLose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCondition);
            Name = "frmWinOrLose";
            Text = "frmWinOrLose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCondition;
    }
}