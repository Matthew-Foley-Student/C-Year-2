/*
 * Matthew Foley
 * CST-250
 * Augest 2025
 * Final Project
 */
using System.Linq.Expressions;
using MineSweeperLibrary.Models;
using MineSweeperLibrary.Services.Buisness_Logic;

namespace MineSweeper
{

    public partial class frmMineSweeper : Form
    {    
        bool isBombValid = false, isRowValid = false, isColValid = false;
        private BoardModel _board;
        private BoardLogic _boardLogic;
        private Button[,] _buttons;
        public frmMineSweeper()
        {
            InitializeComponent();
            lblError.Visible = false;
            lblBoardSize.Visible = true;
            lblBombQuestion.Visible = true;
            txtBombs.Visible = true;
            txtSizeCol.Visible = true;
            txtSizeRow.Visible = true;
            btnGameStart.Visible = true;
        }

        private void SetUpButton()
        {
            int buttonSize = pnlMineSweeper.Width / _board.rows;
            pnlMineSweeper.Height = pnlMineSweeper.Width;
            for (int row = 0; row < _board.rows; row++)
            {
                for (int col = 0; col < _board.cols; col++)
                {
                    _buttons[row, col] = new Button();
                    Button button = _buttons[row, col];
                    //set the size's
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    //Set Button Locations
                    button.Left = row * buttonSize;
                    button.Top = col * buttonSize;
                    //Set the Click Capeabilities for the buttons
                    button.Click += BtnSquareClickEh;
                    //store button's capeabilites
                    button.Tag = new Point(row, col);
                    button.Text = $"{row}, {col}";
                    pnlMineSweeper.Controls.Add(_buttons[row, col]);
                }
            }
        }//End Of SetUp
        private void BtnSquareClickEh(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;
            _board = _boardLogic.Reveal(_board, _board.Grid[row, col]);
            /*
             
            MessageBox.Show($"You Clicked On Row {row} And Column {col}");
            //send everything to buisness layer
            _board = _boardLogic.MassReveal(_board, _board.Grid[row, col]);
            UpdateButtons();
            */
        }//end of BTN
        private void UpdateButtons()
        {

        }

        private void StartGame(object sender, EventArgs e)
        {
            int bombs, row, col;
            isBombValid = int.TryParse(txtBombs.Text, out bombs);
            isRowValid = int.TryParse(txtSizeRow.Text, out row);
            isColValid = int.TryParse(txtSizeCol.Text, out col);                
            if (!isBombValid || !isRowValid || !isColValid)
            {
                lblError.Visible = true;
            }
            else
            {
                pnlMineSweeper.Visible = true;
                lblError.Visible = false;
                lblBoardSize.Visible = false;
                lblBombQuestion.Visible = false;
                txtBombs.Visible = false;
                txtSizeCol.Visible = false;
                txtSizeRow.Visible = false;
                btnGameStart.Visible = false;
                row = Convert.ToInt32(txtSizeRow.Text);
                col = Convert.ToInt32(txtSizeCol.Text);
                bombs = Convert.ToInt32(txtBombs.Text);
                _board = new BoardModel(row, col);


                SetUpButton();
            }
        }
    }
}
