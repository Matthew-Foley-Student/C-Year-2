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
using ChessBoardLibrary.Models;

namespace ChessBoardLibrary.Services.BuisnessLogic
{
    public class BoardLogic
    {
        private BoardModel ResetBoard(BoardModel board)
        {
            foreach(CellModel cell in board.Grid)
            {
                cell.isLegalNextMove = false;
                cell.PieceOccupying = "";
            }
            return board;
        }

        private bool IsOnBoard(BoardModel board, int row, int col)
        {
            int size = board.Size;
            bool IsRowSafe = row >= 0 && row < size;
            bool IsColumnSafe = col >= 0 && col < size;
            return IsRowSafe && IsColumnSafe;
        }
        
        public BoardModel MarkLegalMoves(BoardModel board, CellModel currentCell, string chessPiece)
        {
            board = ResetBoard(board);

            //determine the behavior by the selected piece
            switch (chessPiece.ToLower())
            {
                case "knight":
                    //Movese in the L shape
                    board.Grid[currentCell.Row, currentCell.Collumn].PieceOccupying = "N";
                    board = MarkValidKnightMove(board, currentCell);
                    break;
                case "rook":
                    board.Grid[currentCell.Row, currentCell.Collumn].PieceOccupying = "R";
                    board = MarkValidRookMove(board, currentCell);
                    break;
                case "bishop":
                    board.Grid[currentCell.Row, currentCell.Collumn].PieceOccupying = "B";
                    board = MarkValidBishopMove(board, currentCell);
                    break;
                case "queen":
                    board.Grid[currentCell.Row, currentCell.Collumn].PieceOccupying = "Q";
                    board = MarkValidQueenMove(board,currentCell);
                    break;
                case "king":
                    board.Grid[currentCell.Row, currentCell.Collumn].PieceOccupying = "K";
                    board = MarkValidKingMove(board, currentCell);
                    break;
                default:
                    return board;

            }
            return board;
        }

        private BoardModel MarkValidKnightMove(BoardModel board, CellModel currentCell)
        {
            int[] knightRowMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] knightColMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };
            for (int i = 0; i < knightRowMove.Length; i++)
            {
                if (IsOnBoard(board, currentCell.Row + knightRowMove[i], currentCell.Collumn + knightColMoves[i]))
                {
                    board.Grid[currentCell.Row + knightRowMove[i], currentCell.Collumn + knightColMoves[i]].isLegalNextMove = true;
                }
            }
            return board;
        }
        private BoardModel MarkValidRookMove(BoardModel board, CellModel currentCell)
        {
            int[] rookRowMove = { 1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, -1, -2, -3, -4, -5, -6, -7, -8, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] rookColMove = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, -1, -2, -3, -4, -5, -6, -7, -8 };
            for (int i = 0; i < rookRowMove.Length; i++)
            {
                if (IsOnBoard(board, currentCell.Row + rookRowMove[i], currentCell.Collumn + rookColMove[i]))
                {
                    board.Grid[currentCell.Row + rookRowMove[i], currentCell.Collumn + rookColMove[i]].isLegalNextMove = true;
                }
            }
            return board;
        }
        private BoardModel MarkValidBishopMove(BoardModel board, CellModel currentCell)
        {
            int[] bishopRowMove = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, -1, -2, -3, -4, -5, -6, -7, -8, -1, -2, -3, -4, -5, -6, -7, -8 };
            int[] bishopColMove = { 1, 2, 3, 4, 5, 6, 7, 8, -1, -2, -3, -4, -5, -6, -7, -8, 1, 2, 3, 4, 5, 6, 7, 8, -1, -2, -3, -4, -5, -6, -7, -8 };
            for (int i =0; i<bishopRowMove.Length; i++)
            {
                if(IsOnBoard(board,currentCell.Row + bishopRowMove[i], currentCell.Collumn + bishopColMove[i]))
                {
                    board.Grid[currentCell.Row + bishopRowMove[i], currentCell.Collumn + bishopColMove[i]].isLegalNextMove = true;
                }
            }
            return board;
        }
        private BoardModel MarkValidQueenMove(BoardModel board, CellModel currenCell)
        {
            int[] queenRowMove = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, -1, -2, -3, -4, -5, -6, -7, -8, -1, -2, -3, -4, -5, -6, -7, -8, 1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, -1, -2, -3, -4, -5, -6, -7, -8, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] queenCalMove = { 1, 2, 3, 4, 5, 6, 7, 8, -1, -2, -3, -4, -5, -6, -7, -8, 1, 2, 3, 4, 5, 6, 7, 8, -1, -2, -3, -4, -5, -6, -7, -8, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, -1, -2, -3, -4, -5, -6, -7, -8 };
            for (int i=0; i<queenRowMove.Length; i++)
            {
                if(IsOnBoard(board,currenCell.Row + queenRowMove[i], currenCell.Collumn + queenCalMove[i]))
                {
                    board.Grid[currenCell.Row + queenRowMove[i], currenCell.Collumn + queenCalMove[i]].isLegalNextMove = true;
                }
            }
            return board;
        }
        private BoardModel MarkValidKingMove(BoardModel board, CellModel currentCell)
        {
            int[] kingRowMove={0,1,1,1,0,-1,-1,-1 };
            int[] kingColMove={1,1,0,-1,-1,-1,0,1 };
            for (int i = 0; i < kingRowMove.Length; i++)
            {
                if(IsOnBoard(board,currentCell.Row + kingRowMove[i], currentCell.Collumn + kingColMove[i]))
                {
                    board.Grid[currentCell.Row + kingRowMove[i], currentCell.Collumn + kingColMove[i]].isLegalNextMove = true;
                }
            }
            return board;
        }
    }
}
