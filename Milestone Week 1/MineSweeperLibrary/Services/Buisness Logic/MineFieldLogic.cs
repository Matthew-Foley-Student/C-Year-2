using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MineSweeperLibrary.Models;
using MineSweeperLibrary.Services.Data_Access;

namespace MineSweeperLibrary.Services.Buisness_Logic
{
    public class MineFieldLogic
    {
        private MineFieldDAO _mineFieldDAO;

        public MineFieldLogic()
        {
            _mineFieldDAO = new MineFieldDAO();
        }
        public List<TileField> LayTheFields()
        {
            return _mineFieldDAO.LayTheField();
        }
        public int AddTileToFieldRun(TileField tileField, int rise, int run)
        {
            return _mineFieldDAO.AddTileToFieldRun( tileField,  rise, run);
        }
        public int AddTileToFieldRise(TileField tileField, int rise, int run)
        {
            return _mineFieldDAO.AddTileToFieldRise(tileField, rise, run);
        }
        public bool AddBombToTile(TileField tileField, int rise, int run)
        {
            return _mineFieldDAO.AddBombToField( tileField,  rise,  run);
        }
    }
}
