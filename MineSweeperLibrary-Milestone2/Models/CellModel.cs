/*
 * Matthew Foley
 * CST-250
 * Augest 2025
 * Final Project
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperLibrary.Models
{
    public class CellModel
    {
        public CellModel(int row, int collumn)
        {
            Row = row;
            Collumn = collumn;
            BombRefrence = 0;
            Flag = false;
            Bomb = false;
            Revealed = false;
            Text = "";
        }

        public int Row { get; private set; }
        public int Collumn { get; private set; }
        public int BombRefrence { get; set; }
        public bool Flag { get; set; }
        public bool Bomb { get; set; }
        public bool Revealed { get; set; }
        public string Text { get; set; }
    }
}
