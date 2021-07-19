using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Strategy;
using Rz.GangOfFour.Behavioral.Strategy.DamageCalculationStrategies;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Strategy
    {
        /// <summary>
        /// The pattern is implemented in form of selecting a different armor calculation algorithm depending for
        /// example on game mode.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            //story
            var character = new Character(100, 50,new Default());

            character.ApplyDamage(100);

            Assert.AreEqual(character.Health,50);

            //challenge
            character = new Character(100, 50, new DoubleDamage());

            character.ApplyDamage(100);

            Assert.AreEqual(character.Health, -50);

            //pvp
            character = new Character(100, 50, new IgnoreArmorPercentage(50));

            character.ApplyDamage(100);

            Assert.AreEqual(character.Health, 25);
        }
    }
}
