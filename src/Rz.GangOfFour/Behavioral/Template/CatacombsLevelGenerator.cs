using Rz.GangOfFour.Behavioral.Template.Catacombs;
using Rz.GangOfFour.Behavioral.Template.Common;

namespace Rz.GangOfFour.Behavioral.Template
{
    public class CatacombsLevelGenerator:LevelGeneratorBase
    {
        protected override void FillRoom(Room room)
        {
            //decoration
            room.AddObject(new EmptyCoffin());
            room.AddObject(new EmptyCoffin());
            room.AddObject(new Urn());
            room.AddObject(new OldBones());
        }

        protected override void FillRoomWithTreasure(Room room)
        {
            //decoration
            room.AddObject(new OldBones());
            room.AddObject(new Urn());

            //treasure
            room.AddObject(new TreasureChest());
        }

        protected override void FillRoomWithDanger(Room room)
        {
            //decoration
            room.AddObject(new EmptyCoffin());
            room.AddObject(new Urn());
            room.AddObject(new OldBones());

            //traps

            room.AddObject(new PoisonTrap());
            room.AddObject(new PoisonTrap());
        }
    }
}
