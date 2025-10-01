using System.Security.Cryptography.X509Certificates;
using MineSweeperLibrary.Models;
using MineSweeperLibrary.Services.Buisness_Logic;

namespace MineSweeperTesting
{
    public class UnitTest1
    {
        [Fact]
        public void AddMineToField()
        {
            MineFieldLogic testMine = new MineFieldLogic();

            TileField tile = new TileField
            {
                BombRefrence = 0,
                HasBomb = false,
                HasFlag = false,
                IsShowing = false
            };
            testMine.addTileToField(tile);

        }
    }
}
