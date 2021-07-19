using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Specification;
using Rz.GangOfFour.Structural.Specification.Specifications;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class Specification
    {
        [TestMethod]
        public void Demo()
        {
            var squadA = new Squad
            {
                Soldiers = new List<Soldier>
                {
                    new Soldier(),
                    new Soldier
                    {
                        Veterancy = 1
                    },
                }
            };

            var squadB = new Squad
            {
                Soldiers = new List<Soldier>
                {
                    new Soldier
                    {
                        Veterancy = 1
                    },
                    new Soldier
                    {
                        Veterancy = 1
                    }
                },
                SquadLeader = new Soldier
                {
                    Veterancy = 1
                }
            };
            var squadC = new Squad
            {
                Soldiers = new List<Soldier>
                {
                    new Soldier(),
                    new Soldier()
                },
                SquadLeader = new Soldier
                {
                    IsWounded = true
                }
            };

            var squadD = new Squad
            {
                Soldiers = new List<Soldier>
                {
                    new Soldier
                    {
                        Veterancy = 4
                    },
                    new Soldier()
                },
                SquadLeader = new Soldier()
            };

            var squads = new List<Squad>
            {
                squadA,
                squadB,
                squadC,
                squadD
            };

            var hasTotalVeterancy = new HasTotalVeterancy(3).Check(squads).ToList();

            Assert.AreEqual(hasTotalVeterancy.Count, 2);
            Assert.IsTrue(hasTotalVeterancy.Contains(squadB));
            Assert.IsTrue(hasTotalVeterancy.Contains(squadD));


            var healthyAndNoAbleSquadLeader = new NoAbleSquadLeader().And(new Healthy()).Check(squads).ToList();

            Assert.AreEqual(healthyAndNoAbleSquadLeader.Count,1);
            Assert.AreEqual(healthyAndNoAbleSquadLeader[0], squadA);

            var healthyAndNoSquadLeaderOrHasVeterancy =
                new NoAbleSquadLeader().And(new Healthy()).Or(new HasTotalVeterancy(4)).Check(squads).ToList();

            Assert.AreEqual(healthyAndNoSquadLeaderOrHasVeterancy.Count, 2);
            Assert.IsTrue(healthyAndNoSquadLeaderOrHasVeterancy.Contains(squadA));
            Assert.IsTrue(healthyAndNoSquadLeaderOrHasVeterancy.Contains(squadD));
        }
    }
}
