/*
 * Matthew Foley
 * CST-250
 * 10/27/2025
 * What The Mole
 * Activity 5
 */
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WhackTheMole
{
    public partial class FrmStopWatch : Form
    {
        TimeSpan timeElapse = new TimeSpan();
        Random rand = new Random();
        int score = 5;
        public FrmStopWatch()
        {
            InitializeComponent();
            tmrStopWatch.Stop();
            btnTarget.Visible = false;
            btnBomb.Visible = false;
            lblscore.Text = (score - 5).ToString();
            if (score == 10)
            {
                tmrStopWatch.Stop();
            }

        }

        private void StartingClick(object sender, EventArgs e)
        {
            tmrStopWatch.Start();
            lblscore.Text = (score - 5).ToString();
            if (score == 10)
            {
                tmrStopWatch.Stop();
            }
        }

        private void StopingClick(object sender, EventArgs e)
        {
            tmrStopWatch.Stop();
        }

        private void StopWatchTicking(object sender, EventArgs e)
        {
            int interval = tmrStopWatch.Interval;
            timeElapse = timeElapse.Add(TimeSpan.FromMilliseconds(interval));
            lblTimeElapsed.Text = timeElapse.ToString();
            int target = 3;
            int bomb = 5;
            if (timeElapse.Seconds % target == 0)
            {
                btnTarget.Top = rand.Next(0, this.Height - btnTarget.Height);
                btnTarget.Left = rand.Next(0, this.Height - btnTarget.Width);
                btnTarget.BackColor = Color.FromArgb(rand.Next(0, 50), rand.Next(0, 256), rand.Next(0, 256));
                btnTarget.Visible = true;
                target = rand.Next(0, 9);

            }
            if (timeElapse.Seconds % bomb == 0)
            {
                btnBomb.Top = rand.Next(0, this.Height - btnTarget.Height);
                btnBomb.Left = rand.Next(0, this.Height - btnTarget.Width);
                btnBomb.BackColor = Color.FromArgb(rand.Next(100, 256), rand.Next(0, 50), rand.Next(0, 50));
                btnBomb.Visible = true;
                bomb = rand.Next(0, 9);

            }
            if(timeElapse.Seconds == timeElapse.Seconds + 3&& btnTarget.Visible==true)
            {
                btnTarget.Visible = false;
            }
            if (timeElapse.Seconds == timeElapse.Seconds + 3 && btnBomb.Visible == true)
            {
                btnBomb.Visible = false;
            }
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            tmrStopWatch.Stop();
            timeElapse = new TimeSpan();
            lblTimeElapsed.Text = timeElapse.ToString();
            btnTarget.Visible = false;
            btnBomb.Visible = false;
            score = 5;
        }

        private void TargetClick(object sender, EventArgs e)
        {
            btnTarget.Visible = false;
            score += 1;
            lblscore.Text = (score - 5).ToString();
            if (score >= 10)
            {
                tmrStopWatch.Stop();
                frmWinOrLose win = new frmWinOrLose(true);
                win.Visible = true;
            }
            else if (score <= 0)
            {
                tmrStopWatch.Stop();
                frmWinOrLose lose = new frmWinOrLose(false);
                lose.Visible = true;
            }
        }

        private void MissedButtons(object sender, EventArgs e)
        {
            if (tmrStopWatch.Enabled == true)
            {
                score -= 2;
                lblscore.Text = (score - 5).ToString();
                if (score >= 10)
                {
                    tmrStopWatch.Stop();
                    frmWinOrLose win = new frmWinOrLose(true);
                    win.Visible = true;
                }
                else if(score <= 0) 
                {
                    tmrStopWatch.Stop();
                    frmWinOrLose lose = new frmWinOrLose(false);
                    lose.Visible = true;
                }
            }
        }

        private void FalseTarget(object sender, EventArgs e)
        {
            score -= 3;
            lblscore.Text = (score - 5).ToString();
            if (score == 10)
            {
                tmrStopWatch.Stop();
                frmWinOrLose win = new frmWinOrLose(true);
                win.Visible = true;
            }
            else if (score <= 0)
            {
                tmrStopWatch.Stop();
                frmWinOrLose lose = new frmWinOrLose(false);
                lose.Visible = true;
            }

        }
    }
}
