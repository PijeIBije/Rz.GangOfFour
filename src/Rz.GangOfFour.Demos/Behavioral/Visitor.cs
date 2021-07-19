using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Visitor;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Visitor
    {
        /// <summary>
        /// The pattern is implemented in form of a Promotion object that traverses squads of soldiers and increases
        /// specific stats that represent the applied promotion.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var squad = new Squad(new List<Soldier>
            {
                new Soldier(),
                new Soldier(),
                new Soldier()
            });

            var promotion = new Promotion();

            squad.Apply(promotion);

            Assert.AreEqual(squad.VeterancyLevel,1);
            Assert.AreEqual(squad.Soldiers.First().Damage,1*1.1f);
        }
    }
}
