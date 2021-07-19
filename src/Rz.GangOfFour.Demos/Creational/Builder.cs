using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Creational.Builder;
using Rz.GangOfFour.Creational.Builder.Equipment.Rifles;
using Rz.GangOfFour.Creational.Builder.Equipment.Uniforms;

namespace Rz.GangOfFour.Demos.Creational
{
    [TestClass]
    public class Builder
    {
        /// <summary>
        /// The pattern is implemented in form an interfaces defining operations to build a soldier and then
        /// concrete implementations that build the soldier in certain way according to the specific role he
        /// has to perform.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var riflemanBarracs = new Barracs(new RiflemaBuilder());

            var rifleman = riflemanBarracs.Train();

            Assert.IsTrue(rifleman.Rifle is M4);
            Assert.IsTrue(rifleman.Uniform is BattleDressUniform);

            var sniperBarracs = new Barracs(new SniperBuilder());

            var sniper = sniperBarracs.Train();

            Assert.IsTrue(sniper.Rifle is M82);
            Assert.IsTrue(sniper.Uniform is GhillieSuit);
        }
    }
}
