using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Behavioral.Iterator
{
    //orders soldiers by regiment's position X then by regiment's poistion Y. For soldiers in same regiment orders by rank descending.
    public class SoldierIterator
    {
        private readonly List<Soldier> soldiers;

        private Soldier current;

        public SoldierIterator(List<Soldier> soldiers)
        {
            this.soldiers = soldiers;
        }

        public Soldier Next()
        {
            var nextRank = current?.Rank ?? 10;

            var nextRegimentPositionY = current?.Regiment?.PositionY ?? 0;

            var nextRegimentPostionX = current?.Regiment?.PositionX ?? 0;

            var nextSoldier = soldiers
                .OrderBy(x => x.Regiment.PositionX)
                .ThenBy(x => x.Regiment.PositionY)
                .ThenByDescending(x => x.Rank)
                .FirstOrDefault(x =>
                    (x.Regiment.PositionX == nextRegimentPostionX &&
                     x.Regiment.PositionY == nextRegimentPositionY &&
                     x.Rank < nextRank) ||
                    (x.Regiment.PositionX > nextRegimentPostionX ||
                     (x.Regiment.PositionX == nextRegimentPostionX && x.Regiment.PositionY > nextRegimentPositionY)));

            if (nextSoldier != default)
            {
                current = nextSoldier;
            }

            return nextSoldier;
        }
    }
}
