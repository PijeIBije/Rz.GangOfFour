using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Decorator;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class Decorator
    {
        /// <summary>
        /// Supposedly the soldier is sealed and we can't modify code. We wrap it with a decurator.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var soldier = new Soldier(); //sealed

            Assert.AreEqual(soldier.Attack(), 100);
            Assert.AreEqual(soldier.Attack(), 100);
            Assert.AreEqual(soldier.Attack(), 100);

            var soldierWithStamina = new SoldierStaminaWrapper(new Soldier(), 3);

            Assert.AreEqual(soldierWithStamina.Attack(),100);
            Assert.AreEqual(soldierWithStamina.Stamina, 2);

            Assert.AreEqual(soldierWithStamina.Attack(), 100);
            Assert.AreEqual(soldierWithStamina.Stamina, 1);

            Assert.AreEqual(soldierWithStamina.Attack(), 50); //weak attack - no stamina
            Assert.AreEqual(soldierWithStamina.Stamina, 0);
        }
    }
}
