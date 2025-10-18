/*
 * Matthew Foley
 * CST-250
 * 10/6/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSweeperLibrary.Models;

namespace ChessBoardLibrary.Services.BuisnessLogic
{
    public class BoardLogic
    {
        private BoardModel ResetBoard(BoardModel board)
        {
            foreach (CellModel cell in board.Grid)
            {
                cell.Bomb = false;
                cell.Flag = false;
                cell.Revealed = false;
                cell.BombRefrence = 0;
            }
            return board;
        }

        public BoardModel IsOnBoard(BoardModel board, CellModel currentCell)
        {
            board.Grid[currentCell.Row, currentCell.Collumn].Revealed = true;
            return board;
        }

        public BoardModel CheckForBomb (BoardModel board, CellModel currentCell, bool bombRefrence)
        {
            if (board.Grid[currentCell.Row,currentCell.Collumn].Bomb == true)
            {

            }
            else
            {
                board.Grid[currentCell.Row, currentCell.Collumn].Revealed = true;
            }
            return board;
        }

    }
}

        