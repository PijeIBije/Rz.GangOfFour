using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Command;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Command
    {
        [TestMethod]
        public void Demo()
        {
            var commandInvoker = new CommandInvoker();

            var character = new Character();

            commandInvoker.AddCommand(new MoveCommand(character, 2, 0));
            commandInvoker.AddCommand(new CastSpellCommand(character, "FireBall"));
            commandInvoker.AddCommand(new MoveCommand(character, 0, 2));
            commandInvoker.AddCommand(new CastSpellCommand(character, "MagicMissile"));
            commandInvoker.AddCommand(new MoveCommand(character, 0, -1));

            commandInvoker.ExecuteAll();

            Assert.AreEqual(character.Mana,7);
            Assert.AreEqual(character.PositionX,2);
            Assert.AreEqual(character.PositionY,1);
        }
    }
}
