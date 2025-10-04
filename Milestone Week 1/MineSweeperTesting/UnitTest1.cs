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
                IsShowing = false,
                Rise = 3,
                Run = 4
            };
            testMine.AddBombToTile(tile, 3, 4);
            testMine.AddTileToFieldRise(tile, 3, 4);
            testMine.AddTileToFieldRun(tile, 3, 4);
            testMine.LayTheFields();

        }
    }
}
