/*
 * Matthew Foley
 * CST-250
 * 10/13/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFill.Models
{
    internal class BoardModel
    {
        public int Size {  get; set; }
        public CellModel[,] Grid {  get; set; }
        public int NumShape {  get; set; }

        /// <summary>
        /// Pareemeeter
        /// </summary>
        /// <param name="size"></param>
        public BoardModel(int size, int numShape)
        {
            Size = size;
            NumShape = numShape;
            Grid= new CellModel[Size,Size];
            for (int row =0; row<Size; row++)
            {
                for(int col=0; col<Size; col++)
                {
                    Grid[row, col] = new CellModel(row, col, "E");
                }
            }
            PlaceShape();
        }

        public void PlaceShape()
        {
            Random random = new Random();
            int shapeSize = Size / 2, row = 0, col = 0;
            for(int shapes =0;shapes < NumShape; shapes++)
            {
                row = random.Next(0, Size - shapeSize + 1);
                col = random.Next(0,Size - shapeSize + 1);
                for(int offset =0;offset< shapeSize; offset++)
                {
                    //top of the wall
                    Grid[row, col + offset].Content = "W";
                    //BottomWall
                    Grid[row + shapeSize - 1, col + offset].Content = "W";
                    //LeftWall
                    Grid[row + offset, col].Content = "W";
                    //Right Wall
                    Grid[row + offset, col + shapeSize - 1].Content = "W";
                }
            }
        }
    }
}
