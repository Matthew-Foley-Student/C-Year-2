/*
 * Matthew Foley
 * CST-250
 * 10/13/2025
 * Activity 2
 */
using FloodFill.Models;

//-------------------------------------------------------------------------------------------------------------
//Start Of Method
//-------------------------------------------------------------------------------------------------------------
BoardModel board = new BoardModel(20,1);
Utility.PrintBoard(board);
board = Utility.FloodFill(board, 0, 0);
Utility.PrintBoard(board);
//-------------------------------------------------------------------------------------------------------------
//End Of Method
//-------------------------------------------------------------------------------------------------------------

static class Utility
{
    internal static void PrintBoard(BoardModel board)
    {
        for(int row=0;row<board.Size;row++) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{row + 1,2}");
            for(int col=0; col<board.Size; col++)
            {
                if(board.Grid[row,col].Content == "W")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" W ");
                }
                else if (board.Grid[row,col].Content == "E")
                {
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.Write(" . ");
                }
                else if (board.Grid[row, col].Content == "F")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" ~ ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
         Console.WriteLine();
        }
    }//End Of The PrintBoard

    internal static BoardModel FloodFill(BoardModel board, int row, int col)
    {
        if (row < 0 || row >= board.Size || col < 0 || col >= board.Size)
        {
            return board;
        }
        if (board.Grid[row,col].Content == "W")
        {
            return board;
        }
        else if (board.Grid[row,col].Content == "F")
        {
            return board;
        }
        else
        {
            board.Grid[row, col].Content = "F";
        }
        //calling the fill in the cardnil direction (north east south then west)
        board = FloodFill(board,row - 1,col);
        board = FloodFill(board,row,col+1);
        board = FloodFill(board,row + 1, col);
        board = FloodFill(board,row,col+1);
        return board;
    }
}