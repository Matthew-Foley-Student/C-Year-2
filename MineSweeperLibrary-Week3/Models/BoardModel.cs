/*
 * Matthew Foley
 * CST-250
 * Augest 2025
 * Final Project
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperLibrary.Models
{
    public class BoardModel
    {
        public int Size { get; private set; }
        public CellModel[,] Grid { get; set; }

        public BoardModel(int size)
        {
            Size = size;
            Grid = new CellModel[Size, Size];
            InitilzeBoard();
        }
        private void InitilzeBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = new CellModel(i, j);
                }
            }
        }
    }
}
