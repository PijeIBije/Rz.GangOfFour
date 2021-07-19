using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Structural.Proxy
{
    public class DungeonLazyLoaded : IDungeon
    {
        private readonly string dungeonData;

        private Dungeon actualDungeon = null;

        private Dungeon DeserializeDungeon()
        {
            var roomDatas = dungeonData.Split(":");

            var rooms = new List<Room>();

            foreach (var roomData in roomDatas)
            {
                var roomDataSplit = roomData.Split(",");

                var room = new Room
                {
                    RoomType = Enum.Parse<RoomType>(roomDataSplit[0]),
                    PositionX = int.Parse(roomDataSplit[1]),
                    PositionY = int.Parse(roomDataSplit[2])
                };

                rooms.Add(room);
            }

            return new Dungeon(rooms);
        }

        public DungeonLazyLoaded(string dungeonData)
        {
            this.dungeonData = dungeonData;
        }

        public IReadOnlyList<Room> Rooms => (actualDungeon ??= DeserializeDungeon()).Rooms;
    }
}
