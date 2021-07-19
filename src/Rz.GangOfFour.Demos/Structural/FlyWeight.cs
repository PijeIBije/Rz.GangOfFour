using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Flyweight;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class FlyWeight
    {
        [TestMethod]
        public void Demo()
        {
            var statsA = new Stats("10,10,5");

            var statsB = new Stats("10,10,5");

            Assert.IsFalse(ReferenceEquals(statsA,statsB));

            var statsC = Stats.Get("10,10,5");

            var statsD = Stats.Get("10,10,5");

            Assert.IsTrue(ReferenceEquals(statsC, statsD));
        }
    }
}
