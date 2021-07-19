using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.State;
using Rz.GangOfFour.Behavioral.State.States;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class State
    {
        [TestMethod]
        public void Demo()
        {
            var character = new Character();

            character.Damage(40);

            Assert.AreEqual(character.HitPoints,60);
            Assert.IsTrue(character.State is Alive);

            character.Heal(20);

            Assert.AreEqual(character.HitPoints, 80);
            Assert.IsTrue(character.State is Alive);

            character.Damage(100);

            Assert.AreEqual(character.HitPoints, 100);
            Assert.IsTrue(character.State is Undead);

            character.Heal(20);

            Assert.AreEqual(character.HitPoints, 100);
            Assert.IsTrue(character.State is Undead);

            character.Damage(100);

            Assert.IsTrue(character.State is Ghost);
        }
    }
}
