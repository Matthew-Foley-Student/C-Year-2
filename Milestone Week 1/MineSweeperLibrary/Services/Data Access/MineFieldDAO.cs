using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSweeperLibrary.Models;

namespace MineSweeperLibrary.Services.Data_Access
{
    public class MineFieldDAO
    {
       private List<TileField>_inventory = new List<TileField>();
        private int ParseInteger(string input)
        {
            try
            {
                //parse the input
                return int.Parse(input);
            }
            catch (Exception ex)
            {
                //return 0
                return 0;
                //return 0;
            }
        }
        public List<TileField> _tile;
        public int addTileToField(TileField tile)
        {
            tile.TileId = _inventory.Count + 1;
            _tile.Add(tile);
            return tile.TileId;
        }
    }
}
        
    


