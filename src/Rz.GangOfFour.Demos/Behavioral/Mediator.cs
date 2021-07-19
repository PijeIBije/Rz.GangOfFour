using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Mediator;
using Rz.GangOfFour.Behavioral.Mediator.Messages;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
   public class Mediator
    {
        /// <summary>
        /// There are multiple teams of soldiers, each counting casaulties and each casualty inflicting morale loss.
        /// Mediator class relays messages about killed soldiers so that each team can update their stats in a decoupled way. 
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var mediator = new Rz.GangOfFour.Behavioral.Mediator.Mediator();

            var teamA = new Team("A");
            mediator.RegisterForMessages<KilledBy>(teamA.OnSoldierKilled);

            var teamB = new Team("B");
            mediator.RegisterForMessages<KilledBy>(teamB.OnSoldierKilled);

            var teamASoldiers = new List<Soldier>();

            var teamBSoldiers = new List<Soldier>();

            for (int i = 0; i < 2; i++)
            {
                var teamASoldier = new Soldier(teamA.Name, mediator);
                mediator.RegisterForMessages<KilledBy>(teamASoldier.OnSoldierKilled);
                teamASoldiers.Add(teamASoldier);

                var teamBSoldier = new Soldier(teamB.Name, mediator);
                mediator.RegisterForMessages<KilledBy>(teamBSoldier.OnSoldierKilled);
                teamBSoldiers.Add(teamBSoldier);
            }

            teamASoldiers.First().IsKilledBy(teamBSoldiers.First());

            Assert.IsTrue(teamASoldiers.First().Dead);
            Assert.AreEqual(teamASoldiers.Last().Morale,-1);
            Assert.AreEqual(teamBSoldiers.Last().Morale, 1);
            Assert.AreEqual(teamA.Casualties,1);
            Assert.AreEqual(teamB.Casualties, 0);
        }
    }
}
