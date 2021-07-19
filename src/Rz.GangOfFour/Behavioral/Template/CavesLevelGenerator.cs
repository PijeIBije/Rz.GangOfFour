using Rz.GangOfFour.Behavioral.Template.Caves;
using Rz.GangOfFour.Behavioral.Template.Common;

namespace Rz.GangOfFour.Behavioral.Template
{
    public class CavesLevelGenerator:LevelGeneratorBase
    {
        protected override void FillRoom(Room room)
        {
            //decoration
            room.AddObject(new Rocks());
            room.AddObject(new Stalagmite());
            room.AddObject(new Stalagmite());
            room.AddObject(new EmptyCrate());
        }

        protected override void FillRoomWithTreasure(Room room)
        {
            //decoration
            room.AddObject(new Rocks());
            room.AddObject(new Stalagmite());
            room.AddObject(new EmptyCrate());

            room.AddObject(new TreasureChest());
        }

        protected override void FillRoomWithDanger(Room room)
        {
            //decoration
            room.AddObject(new Rocks());
            room.AddObject(new Stalagmite());
            room.AddObject(new EmptyCrate());

            room.AddObject(new FallingRocks());
            room.AddObject(new FallingRocks());
        }
    }
}
