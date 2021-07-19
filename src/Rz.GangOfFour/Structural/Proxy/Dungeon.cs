using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rz.GangOfFour.Structural.Proxy
{
    public class Dungeon:IDungeon
    {
        public Dungeon(IReadOnlyList<Room> rooms)
        {
            Rooms = rooms.ToList();
        }

        public IReadOnlyList<Room> Rooms { get; }
    }
}
