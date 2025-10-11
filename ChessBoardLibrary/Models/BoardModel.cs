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

namespace ChessBoardLibrary.Models
{
    public class BoardModel
    {
        public int Size { get; private set; }
        public CellModel[,] Grid { get; private set; }

        public BoardModel(int size)
        {
            Size = size;
            Grid = new CellModel[Size, Size];
            InitilzeBoard();
        }
        private void InitilzeBoard()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col =  0; col < Size; col++)
                {
                    Grid[row, col] = new CellModel(row, col);
                }
            }
        }
    }
}
