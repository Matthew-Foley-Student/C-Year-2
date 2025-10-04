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

        public int AddTileToFieldRun(TileField tileField, int rise, int run)
        {
            tileField.Run = run;
            tileField.Rise = rise;
            _inventory.Add(tileField);
            return tileField.Run;

        }
        public int AddTileToFieldRise(TileField tileField, int rise, int run)
        {
            tileField.Rise = rise;
            return tileField.Rise;
        }

        public bool AddBombToField(TileField tileField, int rise, int run)
        {
            tileField.HasBomb = true;
            return tileField.HasBomb;
        }
        public List<TileField> LayTheField()
        {
            return _inventory;
        }
     
    }
}
        
    


