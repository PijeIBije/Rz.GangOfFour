using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Template;
using Rz.GangOfFour.Behavioral.Template.Catacombs;
using Rz.GangOfFour.Behavioral.Template.Caves;
using Rz.GangOfFour.Behavioral.Template.Common;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Template
    {
        [TestMethod]
        public void Demo()
        {
            var cavesLevelGenerator = new CavesLevelGenerator();

            var cavesLevel = cavesLevelGenerator.GenerateLevel(100);

            
            Assert.IsTrue(cavesLevel.Any(room=>room.GameObjects.Any(gameObject=>gameObject is TreasureChest)));
            Assert.IsTrue(cavesLevel.Any(room => room.GameObjects.Any(gameObject => gameObject is FallingRocks)));
            Assert.IsTrue(cavesLevel.Any(room => !room.GameObjects.Any(gameObject => gameObject is TreasureChest || gameObject is FallingRocks)));

            var catacombsLevelGenerator = new CatacombsLevelGenerator();

            var catacombsLevel = catacombsLevelGenerator.GenerateLevel(50);

            Assert.IsTrue(catacombsLevel.Any(room => room.GameObjects.Any(gameObject => gameObject is TreasureChest)));
            Assert.IsTrue(catacombsLevel.Any(room => room.GameObjects.Any(gameObject => gameObject is PoisonTrap)));
            Assert.IsTrue(catacombsLevel.Any(room => !room.GameObjects.Any(gameObject => gameObject is TreasureChest || gameObject is PoisonTrap)));
        }
    }
}
