using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Creational.FactoryMethod;
using Rz.GangOfFour.Creational.FactoryMethod.Barricades;

namespace Rz.GangOfFour.Demos.Creational
{
    [TestClass]
    public class FactoryMethod
    {
        /// <summary>
        /// Supposedly there is a single class for different soldier types. If all types of soliders can build a barricade
        /// then spawning of such object can be delegated to a factory method
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var rifleman = new Soldier("teamA", team => new Sandbags(team));

            var barricade = rifleman.PlaceBarricade();

            Assert.IsTrue(barricade is Sandbags);
            Assert.AreEqual(rifleman.Team,barricade.Team);

            var engineer = new Soldier("teamB", team => new TankTraps(team));

            barricade = engineer.PlaceBarricade();

            Assert.IsTrue(barricade is TankTraps);
            Assert.AreEqual(engineer.Team,barricade.Team);
        }
    }
}
