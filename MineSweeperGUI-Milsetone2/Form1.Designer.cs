namespace MineSweeperGUI
{
    partial class Form1
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
            pnlMineField = new Panel();
            label1 = new Label();
            cmbGrid = new ComboBox();
            cmbBomb = new ComboBox();
            label2 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // pnlMineField
            // 
            pnlMineField.Location = new Point(3, 0);
            pnlMineField.Name = "pnlMineField";
            pnlMineField.Size = new Size(1050, 1050);
            pnlMineField.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1231, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 37);
            label1.TabIndex = 1;
            label1.Text = "Select Grid Size";
            // 
            // cmbGrid
            // 
            cmbGrid.FormattingEnabled = true;
            cmbGrid.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbGrid.Location = new Point(1250, 49);
            cmbGrid.Name = "cmbGrid";
            cmbGrid.Size = new Size(166, 23);
            cmbGrid.TabIndex = 2;
            // 
            // cmbBomb
            // 
            cmbBomb.FormattingEnabled = true;
            cmbBomb.Items.AddRange(new object[] { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbBomb.Location = new Point(1258, 171);
            cmbBomb.Name = "cmbBomb";
            cmbBomb.Size = new Size(158, 23);
            cmbBomb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1217, 118);
            label2.Name = "label2";
            label2.Size = new Size(237, 37);
            label2.TabIndex = 4;
            label2.Text = "Number Of Bombs";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(1231, 215);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(202, 122);
            btnStart.TabIndex = 5;
            btnStart.Text = "Click To Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += StartTheProgram;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 1061);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(cmbBomb);
            Controls.Add(cmbGrid);
            Controls.Add(label1);
            Controls.Add(pnlMineField);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMineField;
        private Label label1;
        private ComboBox cmbGrid;
        private ComboBox cmbBomb;
        private Label label2;
        private Button btnStart;
    }
}
