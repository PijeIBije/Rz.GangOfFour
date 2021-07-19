using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Memento;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Memento
    {
        /// <summary>
        /// The memento pattern allows saving state of a soldier and loading it later on.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var soldier = new Soldier();

            soldier.ApplyDamage(50);

            Assert.AreEqual(soldier.HealthLost,50);
            Assert.IsFalse(soldier.IsHealthy);
            Assert.IsFalse(soldier.IsWounded);

            var soldierState = soldier.GetState();

            soldier.ApplyDamage(40);

            Assert.AreEqual(soldier.HealthLost, 90);
            Assert.IsFalse(soldier.IsHealthy);
            Assert.IsTrue(soldier.IsWounded);

            soldier.SetState(soldierState);

            Assert.AreEqual(soldier.HealthLost, 50);
            Assert.IsFalse(soldier.IsHealthy);
            Assert.IsFalse(soldier.IsWounded);
        }
    }
}
