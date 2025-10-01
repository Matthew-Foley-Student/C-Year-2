using System;
using System.Collections.Generic;
using System.Linq;
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


        public TileField()
        {
            TileId = 0;
            BombRefrence = 0;
            HasBomb = false;
            HasFlag = false;
            IsShowing = false;
        }

        public TileField( int tileID, int bombrefrence,  bool hasBomb, bool hasFlag, bool isShowing)
        {
            TileId = tileID;
            BombRefrence = bombrefrence;
            HasBomb = hasBomb;
            HasFlag = hasFlag;
            IsShowing = isShowing;
        }

    }

}
