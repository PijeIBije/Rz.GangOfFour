using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Adapter;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class Adapter
    {
        [TestMethod]
        public void Demo()
        {
            var soldier = new Soldier();
            var wall = new Wall();

            var destructibles = new List<IDestructible>
            {
                wall,
                new SoldierDestructibleAdapter(soldier)
            };

            foreach (var destructible in destructibles)
            {
                destructible.Destroy();
            }

            Assert.IsTrue(wall.IsDestroyed);
            Assert.IsTrue(soldier.IsDead);
        }
    }
}
