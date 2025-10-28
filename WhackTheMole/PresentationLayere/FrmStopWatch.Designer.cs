namespace WhackTheMole
{
    partial class FrmStopWatch
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
            lblTimeElapsed = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnRestart = new Button();
            tmrStopWatch = new System.Windows.Forms.Timer(components);
            btnTarget = new Button();
            btnBomb = new Button();
            label1 = new Label();
            lblscore = new Label();
            SuspendLayout();
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.Anchor = AnchorStyles.Top;
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(612, 9);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(38, 15);
            lblTimeElapsed.TabIndex = 0;
            lblTimeElapsed.Text = "label1";
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Bottom;
            btnStart.Location = new Point(0, 440);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(1247, 39);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += StartingClick;
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Bottom;
            btnStop.Location = new Point(0, 399);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(1247, 41);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += StopingClick;
            // 
            // btnRestart
            // 
            btnRestart.Dock = DockStyle.Bottom;
            btnRestart.Location = new Point(0, 369);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(1247, 30);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += ResetButtonClick;
            // 
            // tmrStopWatch
            // 
            tmrStopWatch.Enabled = true;
            tmrStopWatch.Interval = 1000;
            tmrStopWatch.Tick += StopWatchTicking;
            // 
            // btnTarget
            // 
            btnTarget.Location = new Point(12, 44);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(113, 89);
            btnTarget.TabIndex = 4;
            btnTarget.Text = "Target";
            btnTarget.UseVisualStyleBackColor = true;
            btnTarget.Click += TargetClick;
            // 
            // btnBomb
            // 
            btnBomb.Location = new Point(1040, 44);
            btnBomb.Name = "btnBomb";
            btnBomb.Size = new Size(113, 89);
            btnBomb.TabIndex = 5;
            btnBomb.Text = "Fake";
            btnBomb.UseVisualStyleBackColor = true;
            btnBomb.Click += FalseTarget;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(522, 343);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 6;
            label1.Text = "Score : ";
            // 
            // lblscore
            // 
            lblscore.Anchor = AnchorStyles.Bottom;
            lblscore.AutoSize = true;
            lblscore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscore.Location = new Point(586, 347);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(50, 20);
            lblscore.TabIndex = 7;
            lblscore.Text = "label2";
            // 
            // FrmStopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 479);
            Controls.Add(lblscore);
            Controls.Add(label1);
            Controls.Add(btnBomb);
            Controls.Add(btnTarget);
            Controls.Add(btnRestart);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimeElapsed);
            Name = "FrmStopWatch";
            Text = "Stop Watch";
            Click += MissedButtons;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimeElapsed;
        private Button btnStart;
        private Button btnStop;
        private Button btnRestart;
        private System.Windows.Forms.Timer tmrStopWatch;
        private Button btnTarget;
        private Button btnBomb;
        private Label label1;
        private Label lblscore;
    }
}
