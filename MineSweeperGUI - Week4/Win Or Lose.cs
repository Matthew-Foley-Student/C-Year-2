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
        public frmWinOrLose(bool Condition)
        {
            InitializeComponent();
            if (Condition == true)
            {
                //WINNER
                lblWinOrLose.Text = "You Are The A Win";
            }
            else
            {
                //Loser
                lblWinOrLose.Text = "You Lose Are If Mabey?";
            }
        }
        public void MakeEvereythingVisable()
        {
            lblWinOrLose.Visible = true;
        }
    }
}
