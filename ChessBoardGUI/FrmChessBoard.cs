using ChessBoardLibrary.Models;
using ChessBoardLibrary.Services.BuisnessLogic;

namespace ChessBoardGUI
{
    public partial class FrmChessBoard : Form
    {
        private BoardModel _board;
        private BoardLogic _boardLogic;
        private Button[,] _buttons; 
        public FrmChessBoard()
        {
            InitializeComponent();
            _board = new BoardModel(8);
            _boardLogic = new BoardLogic();
            _buttons = new Button[8, 8];
            SetUpButton();
        }
        private void SetUpButton()
        {
            int buttonSize = pnlChessBoard.Width / _board.Size;
            pnlChessBoard.Height = pnlChessBoard.Width;
            for(int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col<_board.Size; col++)
                {
                    _buttons[row, col] = new Button();
                    Button button = _buttons[row, col];
                    //set the size's
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    //Set Button Locations
                    button.Left = row * buttonSize;
                    button.Top = col* buttonSize;
                    //Set the Click Capeabilities for the buttons
                    button.Click += BtnSquareClickEh;
                    //store button's capeabilites
                    button.Tag = new Point(row, col);
                    button.Text = $"{row}, {col}";
                    pnlChessBoard.Controls.Add(_buttons[row, col]);
                }
            }
        }//End of the button set up

        private void BtnSquareClickEh(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;
            string piece = cmbChessPieces.Text;

            MessageBox.Show($"You Clicked On Row {row} And Column {col}");
            //send everything to buisness layer
            _board = _boardLogic.MarkLegalMoves(_board, _board.Grid[row, col], piece);
            UpdateButtons();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateButtons()
        {
            string piece;
            Dictionary<string, string> pieceMap = new Dictionary<string, string>
            {
                { "N", "Knight" },
                { "R", "Rook" },
                { "B", "Bishop" },
                { "Q", "Queen" },
                { "K", "King" }
            };
            for(int row = 0; row <_board.Size; row++)
            {
                for(int col = 0; col < _board.Size; col++)
                {
                    if (_board.Grid[row,col].PieceOccupying != "")
                    {
                        piece = pieceMap[_board.Grid[row, col].PieceOccupying];
                        _buttons[row, col].Text = piece;
                    }
                    else if (_board.Grid[row, col].isLegalNextMove)
                    {
                        _buttons[row, col].Text = "Legal Move";
                    }
                    else
                    {
                        _buttons[row, col].Text = "";
                    }
                }
            }
        }//end of button updater
    }
}
