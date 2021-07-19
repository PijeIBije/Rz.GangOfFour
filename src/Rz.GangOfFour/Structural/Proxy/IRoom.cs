using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Structural.Proxy
{
    public interface IDungeon
    {
        IReadOnlyList<Room> Rooms { get; }
    }
}
