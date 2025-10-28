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

        