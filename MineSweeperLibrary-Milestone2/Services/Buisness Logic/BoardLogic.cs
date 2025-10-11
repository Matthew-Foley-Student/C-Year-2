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

        public bool IsOnBoard(BoardModel board, int row, int col)
        {
            int size = board.Size;
            bool IsRowSafe = row >= 0 && row < size;
            bool IsColumnSafe = col >= 0 && col < size;
            return IsRowSafe && IsColumnSafe;
        }
        public BoardModel CheckForBomb(BoardModel board, CellModel currentCell,string bombrefrence)
        {
            switch (bombrefrence.ToLower())
            {
                case "yes":
                    board.Grid[currentCell.Row, currentCell.Collumn].Text = "BOMB!";
                    break;
                case "1":
                    break;
                case "2":
                    break;
                    case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "flag":
                    break;
                default:
                    return board;
            }
            return board;
        }

    }
}

        