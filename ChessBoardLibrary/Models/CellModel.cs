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
    public class CellModel
    {
        public CellModel(int row, int collumn)
        {
            Row = row;
            Collumn = collumn;
            PieceOccupying = "";
            isLegalNextMove = false;
        }

        public int Row { get; private set; }
        public int Collumn { get; private set; }
        public string PieceOccupying {  get; set; }
        public bool isLegalNextMove { get; set; }
    }

}
