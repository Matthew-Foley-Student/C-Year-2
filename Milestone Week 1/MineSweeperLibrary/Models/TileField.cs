using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperLibrary.Models
{
    public class TileField
    {
        public int TileId { get; set; }
        public int BombRefrence { get; set; }
        public Boolean HasBomb { get; set; }
        public Boolean HasFlag { get; set; }
        public Boolean IsShowing { get; set; }
        public int Rise { get; set; }
        public int Run {  get; set; }


        public TileField()
        {
            TileId = 0;
            BombRefrence = 0;
            HasBomb = false;
            HasFlag = false;
            IsShowing = false;
            Rise = 0;
            Run = 0;
        }

        public TileField( int tileID, int bombrefrence,  bool hasBomb, bool hasFlag, bool isShowing, int rise, int run)
        {
            TileId = tileID;
            BombRefrence = bombrefrence;
            HasBomb = hasBomb;
            HasFlag = hasFlag;
            IsShowing = isShowing;
            Rise = rise;
            Run = run;
        }

    }

}
