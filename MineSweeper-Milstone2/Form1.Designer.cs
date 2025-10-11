namespace MineSweeper
{
    partial class frmMineSweeper
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
            lblBombQuestion = new Label();
            lblBoardSize = new Label();
            btnGameStart = new Button();
            lblError = new Label();
            txtSizeRow = new TextBox();
            txtSizeCol = new TextBox();
            txtBombs = new TextBox();
            pnlMineSweeper = new Panel();
            SuspendLayout();
            // 
            // lblBombQuestion
            // 
            lblBombQuestion.AutoSize = true;
            lblBombQuestion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBombQuestion.Location = new Point(852, 764);
            lblBombQuestion.Name = "lblBombQuestion";
            lblBombQuestion.Size = new Size(432, 25);
            lblBombQuestion.TabIndex = 0;
            lblBombQuestion.Text = "How Many Bombs Do You Want In The MineField?";
            // 
            // lblBoardSize
            // 
            lblBoardSize.AutoSize = true;
            lblBoardSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoardSize.Location = new Point(38, 764);
            lblBoardSize.Name = "lblBoardSize";
            lblBoardSize.Size = new Size(393, 25);
            lblBoardSize.TabIndex = 1;
            lblBoardSize.Text = "What Size Do You Want The MineField To Be?";
            // 
            // btnGameStart
            // 
            btnGameStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGameStart.Location = new Point(1307, 769);
            btnGameStart.Name = "btnGameStart";
            btnGameStart.Size = new Size(269, 69);
            btnGameStart.TabIndex = 2;
            btnGameStart.Text = "Start Game";
            btnGameStart.UseVisualStyleBackColor = true;
            btnGameStart.Click += StartGame;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(409, 808);
            lblError.Name = "lblError";
            lblError.Size = new Size(548, 30);
            lblError.TabIndex = 3;
            lblError.Text = "Required Fields Either Not Inputed Or Incorrectly Inputted";
            // 
            // txtSizeRow
            // 
            txtSizeRow.Location = new Point(66, 804);
            txtSizeRow.Name = "txtSizeRow";
            txtSizeRow.Size = new Size(100, 23);
            txtSizeRow.TabIndex = 4;
            // 
            // txtSizeCol
            // 
            txtSizeCol.Location = new Point(219, 804);
            txtSizeCol.Name = "txtSizeCol";
            txtSizeCol.Size = new Size(100, 23);
            txtSizeCol.TabIndex = 5;
            // 
            // txtBombs
            // 
            txtBombs.Location = new Point(1172, 817);
            txtBombs.Name = "txtBombs";
            txtBombs.Size = new Size(112, 23);
            txtBombs.TabIndex = 6;
            txtBombs.Text = "\r\n";
            // 
            // pnlMineSweeper
            // 
            pnlMineSweeper.Location = new Point(7, 12);
            pnlMineSweeper.Name = "pnlMineSweeper";
            pnlMineSweeper.Size = new Size(1574, 743);
            pnlMineSweeper.TabIndex = 7;
            // 
            // frmMineSweeper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 852);
            Controls.Add(pnlMineSweeper);
            Controls.Add(txtBombs);
            Controls.Add(txtSizeCol);
            Controls.Add(btnGameStart);
            Controls.Add(txtSizeRow);
            Controls.Add(lblBombQuestion);
            Controls.Add(lblError);
            Controls.Add(lblBoardSize);
            Name = "frmMineSweeper";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBombQuestion;
        private Label lblBoardSize;
        private Button btnGameStart;
        private Label lblError;
        private TextBox txtSizeRow;
        private TextBox txtSizeCol;
        private TextBox txtBombs;
        private Panel pnlMineSweeper;
    }
}
