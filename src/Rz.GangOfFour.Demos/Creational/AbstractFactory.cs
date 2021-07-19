using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Creational.AbstractFactory;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Rifles;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Uniforms;

namespace Rz.GangOfFour.Demos.Creational
{
    [TestClass]
    public class AbstractFactory
    {
        [TestMethod]
        public void Demo()
        {
            var riflemanBarracs = new Barracs(new RiflemanEquipmentFactory());

            var rifleman = riflemanBarracs.Train();

            Assert.IsTrue(rifleman.Rifle is M4);
            Assert.IsTrue(rifleman.Uniform is BattleDressUniform);

            var sniperBarracs = new Barracs(new SniperEquipmentFactory());

            var sniper = sniperBarracs.Train();

            Assert.IsTrue(sniper.Rifle is M82);
            Assert.IsTrue(sniper.Uniform is GhillieSuit);
        }
    }
}
