/*
 * Matthew Foley
 * CST-250
 * 10/6/2025
 * Activity 2
 */
// See https://aka.ms/new-console-template for more information
using ChessBoardLibrary.Models;
using ChessBoardLibrary.Services.BuisnessLogic;

string piece = "";
Tuple<int, int>? result;
BoardLogic boardLogic = new BoardLogic();

Console.WriteLine("Hello Chess Player");
BoardModel board = new BoardModel(8);
utility.printboard(board);
Console.Write("Enter the peice that you want to place (Knight , Rook , Bishop , Queen , King): ");
piece = Console.ReadLine();
result = utility.GetRowAndCol();
board = boardLogic.MarkLegalMoves(board, board.Grid[result.Item1, result.Item2], piece);
utility.printboard(board);

//---------------------------------------------------------------------------------------
//Define the Utilities
//---------------------------------------------------------------------------------------
public static class utility
{
    internal static void printboard(BoardModel board)
    {
        for (int row = 0; row < board.Size; row++)
        {
            for (int col = 0; col < board.Size; col++)
            {
                CellModel cell = board.Grid[row, col];
                if (cell.isLegalNextMove)
                {
                    Console.Write("+");
                }
                else if (cell.PieceOccupying != "")
                {
                    Console.Write(" . ");
                }
            }
            Console.WriteLine();
        }
    }//end of board printer

    internal static Tuple<int, int> GetRowAndCol()
    {
        Console.Write("Enter the row number: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter the collumn: ");
        int col = int.Parse(Console.ReadLine());
        return Tuple.Create(row, col);
    }//End of the Tuple
}

