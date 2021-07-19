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
        /// <summary>
        /// The pattern is implemented in a way that if a squad upon creation is not supplied with a squad leader a logically empty
        /// placeholder will be used. Upon increasing squads veterancy in an iterative way squads with null squad leader will throw
        /// an exception.
        /// </summary>
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
