using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
