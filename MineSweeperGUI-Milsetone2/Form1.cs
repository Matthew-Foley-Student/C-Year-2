using ChessBoardLibrary.Services.BuisnessLogic;
using MineSweeperLibrary.Models;

namespace MineSweeperGUI
{
    public partial class Form1 : Form
    {
        private BoardModel _board;
        private BoardLogic _boardLogic;
        private Button[,] _buttons;
        public Form1()
        {
            InitializeComponent();
            _boardLogic = new BoardLogic();
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
            string box = _board.Grid[row, col].Text;
            MessageBox.Show($"You Clicked On Row {row} And Column {col}");
            //send everything to buisness layer
            _board = _boardLogic.CheckForBomb(_board, _board.Grid[row,col], box);
            UpdateButtons();
        }
        private void UpdateButtons()
        {
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++) 
                {
                    _buttons[row, col].Text = _board.Grid[row, col].Text;
                }
            }
        }//end of button updateer

        private void StartTheProgram(object sender, EventArgs e)
        {
            int size = 0, numbomb = 0;
             size = Convert.ToInt32(cmbGrid.Text);
             numbomb = Convert.ToInt32(cmbBomb.Text);
            if(size ==0 ||numbomb == 0)
            {

            }
            else
            {
                _board = new BoardModel(size);
                _boardLogic = new BoardLogic();
                _buttons = new Button[size, size];
                SetUpButton();
            }

            
        }
    }
}
