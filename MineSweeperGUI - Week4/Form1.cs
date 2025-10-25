/*
 * Matthew Foley
 * CST-250
 * 10/6/2025
 * Activity 2
 */
using System.Diagnostics;
using System.Linq.Expressions;
using ChessBoardLibrary.Services.BuisnessLogic;
using MineSweeperLibrary.Models;

namespace MineSweeperGUI
{
    public partial class Form1 : Form
    {
        private BoardModel _board;
        private BoardLogic _boardLogic;
        private Button[,] _buttons;
        private bool setflag = false;
        private bool keepflag = true;
        int score = 0;
        int numBomb;
        int boardsize;
        public Form1()
        {
            InitializeComponent();
            _boardLogic = new BoardLogic();
            rdoVisit.Checked = true;
            rdoFlagKeeper.Checked = true;
            lblWin.Visible = false;
            lblLose.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetUpButton()
        {
            int buttonSize = pnlMineField.Width / _board.Size;
            pnlMineField.Height = pnlMineField.Width;
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    _buttons[row, col] = new Button();
                    Button button = _buttons[row, col];
                    //set the size's
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    //Set Button Locations
                    button.Left = row * buttonSize;
                    button.Top = col * buttonSize;
                    _board.Grid[row, col].Revealed = false;
                    _board.Grid[row, col].Bomb = false;
                    _board.Grid[row, col].Flag = false;
                    _board.Grid[row, col].BombRefrence = 0;
                    //Set the Click Capeabilities for the buttons
                    button.Click += BtnSquareClickEh;
                    //store button's capeabilites
                    button.Tag = new Point(row, col);
                    button.Text = $"{row}, {col}";
                    pnlMineField.Controls.Add(_buttons[row, col]);
                }
            }
        }//end of the panel setups
        private void BtnSquareClickEh(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;

            MessageBox.Show($"You Clicked On Row {row} And Column {col}");
            //send everything to buisness layer
            _board = _boardLogic.IsOnBoard(_board, _board.Grid[row, col]);
            if (keepflag == true)
            {
                if (setflag == true && _board.Grid[row, col].Revealed == false)
                {
                    _board.Grid[row, col].Flag = true;
                    _buttons[row, col].BackColor = Color.Yellow;
                    _board.Grid[row, col].Revealed = false;
                }
                if(setflag == true && _board.Grid[row,col].Revealed == true)
                {

                }
                if (setflag == false) {
                        if (_board.Grid[row, col].Flag == true)
                        {

                            _board.Grid[row, col].Revealed = false;
                            _buttons[row, col].BackColor = Color.Yellow;
                            UpdateButtons();
                        }
                        else if (_board.Grid[row, col].Bomb == true&&setflag==false&& _board.Grid[row, col].Flag == false)
                        {
                            for (int i = 0; i < _board.Size; i++)
                            {
                                for (int j = 0; j < _board.Size; j++)
                                {
                                    _board.Grid[i, j].Flag = false;
                                    _board.Grid[i, j].Revealed = true;
                             
                                }
                            }
                            lblLose.Visible = true;  
                        frmWinOrLose loss = new frmWinOrLose(false);
                        loss.Visible = true;
                        }
                        if (_board.Grid[row, col].BombRefrence == 0 && setflag == false && _board.Grid[row, col].Flag == false)
                        {
                            FloodFill2(_board, row, col);
                        }


                        else if(setflag == false)
                        {
                            _board.Grid[row, col].Revealed = true;
                        }
                    
                }
            }
            else
            {
                _board.Grid[row, col].Flag = false;
                _buttons[row, col].BackColor = Color.LightGray;
            }
            UpdateButtons();
            CeckForWin();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void UpdateButtons()
        {
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    if (_board.Grid[row, col].Bomb == true && _board.Grid[row, col].Revealed == true && _board.Grid[row, col].Flag != true)
                    {
                        _buttons[row, col].Text = "B";
                        _buttons[row, col].BackColor = Color.Red;
                    }
                    else if (_board.Grid[row, col].Flag == true && _board.Grid[row, col].Revealed == false)
                    {
                        _buttons[row, col].Text = "F";
                        _buttons[row, col].BackColor = Color.Yellow;
                    }
                    else if (_board.Grid[row, col].BombRefrence == 0 && _board.Grid[row, col].Revealed == true && _board.Grid[row, col].Flag != true)
                    {
                        _buttons[row, col].Text = "0";
                        _buttons[row, col].BackColor = Color.Green;
                        
                       
                    }
                    else if (_board.Grid[row, col].Revealed == true && _board.Grid[row, col].Flag != true)
                    {
                        _buttons[row, col].Text = _board.Grid[row, col].BombRefrence.ToString();
                        _buttons[row, col].BackColor = Color.Blue;
                    }

                }
            }
        }//end of button updateer
        public BoardModel FloodFill(BoardModel board, int row, int col)
        {
            if (row < 0 || row >= board.Size || col < 0 || col >= board.Size)
            {
                return board;
            }
            if (board.Grid[row, col].BombRefrence != 0)
            {
                return board;
            }
            if (board.Grid[row, col].BombRefrence == 0)
            {
                try
                {
                    board.Grid[row, col].Revealed = true;
                }
                catch {}
                try
                {
                    board.Grid[row + 1, col + 1].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row + 1, col - 1].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row + 1, col].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row - 1, col + 1].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row - 1, col - 1].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row - 1, col].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row, col + 1].Revealed = true;
                }
                catch { }
                try
                {
                    board.Grid[row, col - 1].Revealed = true;
                }
                catch { }
            }
            return board;
        }

        private void CeckForWin()
        {
            if (lblLose.Visible == false)
            {
                int check = 0;
                for (int i = 0; i < _board.Size; i++)
                {
                    for (int j = 0; j < _board.Size; j++)
                    {
                        if (_board.Grid[i, j].Revealed == true)
                        {
                            check++;
                        }
                    }
                }
                if (check >= boardsize - numBomb)
                {
                    frmWinOrLose win = new frmWinOrLose(true);
                    win.Visible= true;
                }            

            }
        }

        private void PlaceBombs()
        {
            Random rand = new Random();
            int brow = rand.Next(0, _board.Size);
            int bcol = rand.Next(0, _board.Size);
            int truestop = Convert.ToInt32(cmbBomb.Text);
            for (int stop = 0; stop < truestop; stop++)
            {
                if (_board.Grid[brow, bcol].Bomb == true)
                {
                    brow = rand.Next(0, _board.Size);
                    bcol = rand.Next(0, _board.Size);
                    stop--;

                }
                else
                {
                    _board.Grid[brow, bcol].Bomb = true;
                    try
                    {
                        _board.Grid[brow + 1, bcol + 1].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow + 1, bcol - 1].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow + 1, bcol].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow - 1, bcol + 1].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow - 1, bcol - 1].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow - 1, bcol].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow, bcol + 1].BombRefrence++;
                    }
                    catch (Exception e) { }
                    try
                    {
                        _board.Grid[brow, bcol - 1].BombRefrence++;
                    }
                    catch (Exception e) { }
                    brow = rand.Next(0, _board.Size);
                    bcol = rand.Next(0, _board.Size);
                }

            }


        }

        private void StartTheProgram(object sender, EventArgs e)
        {
            int size = 0, numbomb = 0;
            try
            {
                size = Convert.ToInt32(cmbGrid.Text);
                numbomb = Convert.ToInt32(cmbBomb.Text);
                if (size == 0 || numbomb == 0)

                {

                }
                else
                {
                    _board = new BoardModel(size);
                    _boardLogic = new BoardLogic();
                    _buttons = new Button[size, size];
                    SetUpButton();
                    PlaceBombs();
                }
            }
            catch ( Exception) { }
            boardsize = size*size;
            numBomb = numbomb;


        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setflag = true;
        }

        private void rdoVisit_CheckedChanged(object sender, EventArgs e)
        {
            setflag = false;
        }

        private void rdoFlagKeeper_CheckedChanged(object sender, EventArgs e)
        {
            keepflag = true;
        }

        private void rdoRemoveFlags_CheckedChanged(object sender, EventArgs e)
        {
            keepflag = false;
        }           
        public BoardModel FloodFill2(BoardModel board, int row, int col)
        {
            board.Grid[row, col].Revealed = true;
            try
            {
                if (board.Grid[row + 1, col].BombRefrence == 0 && board.Grid[row + 1, col].Revealed == false && board.Grid[row + 1, col] != null)
                {
                    FloodFill2(board, row + 1, col);
                }
                else
                {
                    board.Grid[row + 1, col].Revealed = true;
                }
            }
            catch { }
            try
            {
                if (board.Grid[row - 1, col].BombRefrence == 0 && board.Grid[row - 1, col].Revealed == false && board.Grid[row - 1, col] != null)
                {
                    FloodFill2(board, row - 1, col);
                }
                else
                {
                    board.Grid[row - 1, col].Revealed = true;
                }
            }
            catch { }
            if (board.Grid[row, col+1].BombRefrence == 0 && board.Grid[row, col+1].Revealed == false && board.Grid[row, col+1] != null)
            {
                FloodFill2(board, row, col+1);
            }
            else
            {
                board.Grid[row, col + 1].Revealed = true;
            }
                try
                {
                    if (board.Grid[row, col - 1].BombRefrence == 0 && board.Grid[row, col - 1].Revealed == false && board.Grid[row, col - 1] != null)
                    {
                        FloodFill2(board, row, col - 1);
                    }
                else
                {
                    board.Grid[row, col - 1].Revealed = true;
                }
                }
                catch { }
            return board;
        }
    }


}
