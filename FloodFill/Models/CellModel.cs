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
    internal class CellModel
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Content { get; set; }

        public CellModel(int row, int col, string content)
        {
            Row = row;
            Col = col;
            Content = content;
        }
    }
}
