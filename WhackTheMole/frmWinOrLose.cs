/*
 * Matthew Foley
 * CST-250
 * 10/27/2025
 * What The Mole
 * Activity 5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackTheMole
{
    public partial class frmWinOrLose : Form
    {
        public frmWinOrLose(bool winorlose)
        {
            InitializeComponent();
            if(winorlose == true)
            {
                lblCondition.Text = "You Win";
            }
            else
            {
                lblCondition.Text = "You Lose";
            }
        }
    }
}
