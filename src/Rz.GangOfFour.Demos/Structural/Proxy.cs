using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Proxy;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class Proxy
    {
        [TestMethod]
        public void Demo()
        {
            var dungeon = new Dungeon
            (
                new[]
                {
                    new Room
                    {
                        PositionX = 0,
                        PositionY = 0,
                        RoomType = RoomType.Chamber
                    },
                    new Room
                    {
                        PositionX = 1,
                        PositionY = 0,
                        RoomType = RoomType.Passage
                    },
                }
            );

            var dungeonLazyLoaded = new DungeonLazyLoaded("Chamber,0,0:Passage,1,0");

            var allDungeons = new List<IDungeon>
            {
                dungeon,
                dungeonLazyLoaded
            };

            foreach (var dungeonTested in allDungeons)
            {
                Assert.AreEqual(dungeonTested.Rooms[0].RoomType, RoomType.Chamber);
                Assert.AreEqual(dungeonTested.Rooms[0].PositionX, 0);
                Assert.AreEqual(dungeonTested.Rooms[0].PositionY, 0);

                Assert.AreEqual(dungeonTested.Rooms[1].RoomType, RoomType.Passage);
                Assert.AreEqual(dungeonTested.Rooms[1].PositionX, 1);
                Assert.AreEqual(dungeonTested.Rooms[1].PositionY, 0);
            }
        }
    }
}
