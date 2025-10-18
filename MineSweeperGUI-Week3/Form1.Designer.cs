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
            rdoSetFlag = new RadioButton();
            rdoVisit = new RadioButton();
            rdoFlagKeeper = new RadioButton();
            rdoRemoveFlags = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblWin = new Label();
            lblLose = new Label();
            lblTesting = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMineField
            // 
            pnlMineField.Location = new Point(3, 0);
            pnlMineField.Name = "pnlMineField";
            pnlMineField.Size = new Size(1000, 1000);
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
            cmbGrid.Items.AddRange(new object[] { "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbGrid.Location = new Point(1250, 49);
            cmbGrid.Name = "cmbGrid";
            cmbGrid.Size = new Size(166, 23);
            cmbGrid.TabIndex = 2;
            // 
            // cmbBomb
            // 
            cmbBomb.FormattingEnabled = true;
            cmbBomb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" });
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
            // rdoSetFlag
            // 
            rdoSetFlag.AutoSize = true;
            rdoSetFlag.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoSetFlag.Location = new Point(4, 16);
            rdoSetFlag.Name = "rdoSetFlag";
            rdoSetFlag.Size = new Size(100, 32);
            rdoSetFlag.TabIndex = 7;
            rdoSetFlag.TabStop = true;
            rdoSetFlag.Text = "Set Flag";
            rdoSetFlag.UseVisualStyleBackColor = true;
            rdoSetFlag.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoVisit
            // 
            rdoVisit.AutoSize = true;
            rdoVisit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoVisit.Location = new Point(4, 119);
            rdoVisit.Name = "rdoVisit";
            rdoVisit.Size = new Size(148, 32);
            rdoVisit.TabIndex = 7;
            rdoVisit.TabStop = true;
            rdoVisit.Text = "Check Square";
            rdoVisit.UseVisualStyleBackColor = true;
            rdoVisit.CheckedChanged += rdoVisit_CheckedChanged;
            // 
            // rdoFlagKeeper
            // 
            rdoFlagKeeper.AutoSize = true;
            rdoFlagKeeper.Location = new Point(24, 31);
            rdoFlagKeeper.Name = "rdoFlagKeeper";
            rdoFlagKeeper.Size = new Size(81, 19);
            rdoFlagKeeper.TabIndex = 8;
            rdoFlagKeeper.TabStop = true;
            rdoFlagKeeper.Text = "Keep Flags";
            rdoFlagKeeper.UseVisualStyleBackColor = true;
            rdoFlagKeeper.CheckedChanged += rdoFlagKeeper_CheckedChanged;
            // 
            // rdoRemoveFlags
            // 
            rdoRemoveFlags.AutoSize = true;
            rdoRemoveFlags.Location = new Point(159, 31);
            rdoRemoveFlags.Name = "rdoRemoveFlags";
            rdoRemoveFlags.Size = new Size(93, 19);
            rdoRemoveFlags.TabIndex = 9;
            rdoRemoveFlags.TabStop = true;
            rdoRemoveFlags.Text = "Remove Flag";
            rdoRemoveFlags.UseVisualStyleBackColor = true;
            rdoRemoveFlags.CheckedChanged += rdoRemoveFlags_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoVisit);
            groupBox1.Controls.Add(rdoSetFlag);
            groupBox1.Location = new Point(1005, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 176);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flag Setters";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoRemoveFlags);
            groupBox2.Controls.Add(rdoFlagKeeper);
            groupBox2.Location = new Point(1008, 743);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 83);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flag Removers";
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWin.ForeColor = Color.Green;
            lblWin.Location = new Point(1081, 413);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(179, 54);
            lblWin.TabIndex = 12;
            lblWin.Text = "You  Win";
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLose.ForeColor = Color.Red;
            lblLose.Location = new Point(1081, 467);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(178, 54);
            lblLose.TabIndex = 13;
            lblLose.Text = "You Lose";
            // 
            // lblTesting
            // 
            lblTesting.AutoSize = true;
            lblTesting.Location = new Point(1315, 628);
            lblTesting.Name = "lblTesting";
            lblTesting.Size = new Size(38, 15);
            lblTesting.TabIndex = 14;
            lblTesting.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 1061);
            Controls.Add(lblTesting);
            Controls.Add(lblLose);
            Controls.Add(lblWin);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(cmbBomb);
            Controls.Add(cmbGrid);
            Controls.Add(label1);
            Controls.Add(pnlMineField);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private RadioButton rdoSetFlag;
        private RadioButton rdoVisit;
        private RadioButton rdoFlagKeeper;
        private RadioButton rdoRemoveFlags;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblWin;
        private Label lblLose;
        private Label lblTesting;
    }
}
