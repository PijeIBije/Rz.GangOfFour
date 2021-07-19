using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Creational.Prototype;
using Rz.GangOfFour.Creational.Prototype.Equipment.Rifles;
using Rz.GangOfFour.Creational.Prototype.Equipment.Uniforms;

namespace Rz.GangOfFour.Demos.Creational
{
    [TestClass]
    public class Prototype
    {
        [TestMethod]
        public void Demo()
        {
            var riflemanBarracs = new Barracs(new RiflemanPrototype());

            var rifleman = riflemanBarracs.Train();

            Assert.IsTrue(rifleman.Rifle is M4);
            Assert.IsTrue(rifleman.Uniform is BattleDressUniform);

            var sniperBarracs = new Barracs(new SniperPrototype());

            var sniper = sniperBarracs.Train();

            Assert.IsTrue(sniper.Rifle is M82);
            Assert.IsTrue(sniper.Uniform is GhillieSuit);
        }
    }
}
