using System.Collections.Generic;

namespace Rz.GangOfFour.Behavioral.Template
{
    public abstract class LevelGeneratorBase
    {
        protected abstract void FillRoom(Room room);

        protected abstract void FillRoomWithTreasure(Room room);

        protected abstract void FillRoomWithDanger(Room room);

        public List<Room> GenerateLevel(int numberOfRooms)
        {
            var result = new List<Room>();

            var tresureRooms = (int) (numberOfRooms * 0.1);
            var dangerRooms = (int) (numberOfRooms * 0.3);
            var remainingRooms = numberOfRooms - tresureRooms - dangerRooms;

            for (int i = 0; i < tresureRooms; i++)
            {
                var room = new Room();
                FillRoomWithTreasure(room);
                result.Add(room);
            }

            for (int i = 0; i < dangerRooms; i++)
            {
                var room = new Room();
                FillRoomWithDanger(room);
                result.Add(room);
            }

            for (int i = 0; i < remainingRooms; i++)
            {
                var room = new Room();
                FillRoom(room);
                result.Add(room);
            }

            return result;
        }
    }
}
