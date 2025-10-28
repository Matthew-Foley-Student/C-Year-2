using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class frmWinOrLose : Form
    {
        public frmWinOrLose(bool Condition, int score)
        {
            InitializeComponent();
            if (Condition == true)
            {
                //WINNER
                lblWinOrLose.Text = "You Are The A Win";
                lblScore.Text = score.ToString();
            }
            else
            {
                //Loser
                lblWinOrLose.Text = "You Lose Are If Mabey?";
                lblScore.Text = score.ToString();
            }
        }
        public void MakeEvereythingVisable()
        {
            lblWinOrLose.Visible = true;

        }
    }
}
