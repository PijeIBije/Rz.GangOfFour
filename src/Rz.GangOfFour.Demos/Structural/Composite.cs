using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Composite;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class Composite
    {
        /// <summary>
        /// Quest can be completed if requirements are fulfilled, however if quests has subquests all of them have to be completed as well.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var mainQuest = new QuestWithSubquests(
                "Defeat Undead Army",
                new IQuest[]
                {
                    new Quest("Defeat Undead King"),
                    new QuestWithSubquests("Liberate First City",
                        new IQuest[]
                        {
                            new Quest("Defeat Undead Captain"),
                            new Quest("Defeat 50 Skeletons")
                        }),
                    new QuestWithSubquests("Liberate Second City",
                        new IQuest[]
                        {
                            new Quest("Defeat 50 Zombies."),
                        }),
                });

            Assert.AreEqual(mainQuest.AllQuests.Count(),7);

        }
    }
}
