using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.NullObject;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class NullObject
    {
        [TestMethod]
        public void Demo()
        {
            var squadA = new Squad(false) {SquadLeader = new SquadLeader("Player1")};

            var squadB = new Squad(false);

            var squads = new List<Squad>{squadA,squadB};

            Assert.ThrowsException<NullReferenceException>(() => squads.ForEach(x => x.SquadLeader.SetVeterancy(1)));

            squadA = new Squad(true) { SquadLeader = new SquadLeader("Player1") };

            squadB = new Squad(true);

            squads = new List<Squad> { squadA, squadB };

            squads.ForEach(x => x.SquadLeader.SetVeterancy(1));

            Assert.AreEqual(squadB.SquadLeader.PlayerName, new NullSquadLeader().PlayerName);
            Assert.AreEqual(squads.Sum(x=>x.SquadLeader.Veterancy),1);
        }
    }
}
