using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Iterator;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Iterator
    {
        /// <summary>
        /// Assuming there can be multiple soldiers on same x,y coordinates of different rank and regiments the pattern is implemented
        /// in form of an iterator that iterates over them in order of coordinate x,y then rank
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var regimentA = new Regiment
            {
                PositionX = 1,
                PositionY = 0
            };

            var regimentB = new Regiment
            {
                PositionX = 0,
                PositionY = 0
            };

            var regimentC = new Regiment
            {
                PositionX = 0,
                PositionY = 1
            };

            var soldiers = new List<Soldier>
            {
                new Soldier
                {
                    Regiment = regimentA,
                    Rank = 1,
                },

                new Soldier
                {
                    Regiment = regimentB,
                    Rank = 3,
                },
                new Soldier
                {
                    Regiment = regimentB,
                    Rank = 4,
                },
                new Soldier
                {
                    Regiment = regimentC,
                    Rank = 1,
                },
            };

            var soldierIterator = new SoldierIterator(soldiers);

            var currentSoldier = soldierIterator.Next();

            Assert.AreEqual(currentSoldier.Regiment.PositionX,regimentB.PositionX);
            Assert.AreEqual(currentSoldier.Regiment.PositionY, regimentB.PositionY);
            Assert.AreEqual(currentSoldier.Rank, 4);

            currentSoldier = soldierIterator.Next();

            Assert.AreEqual(currentSoldier.Regiment.PositionX, regimentB.PositionX);
            Assert.AreEqual(currentSoldier.Regiment.PositionY, regimentB.PositionY);
            Assert.AreEqual(currentSoldier.Rank, 3);

            currentSoldier = soldierIterator.Next();

            Assert.AreEqual(currentSoldier.Regiment.PositionX, regimentC.PositionX);
            Assert.AreEqual(currentSoldier.Regiment.PositionY, regimentC.PositionY);

            currentSoldier = soldierIterator.Next();

            Assert.AreEqual(currentSoldier.Regiment.PositionX, regimentA.PositionX);
            Assert.AreEqual(currentSoldier.Regiment.PositionY, regimentA.PositionY);

            currentSoldier = soldierIterator.Next();

            Assert.IsNull(currentSoldier);

        }
    }
}
