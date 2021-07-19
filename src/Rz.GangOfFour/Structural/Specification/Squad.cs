using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Structural.Specification
{
    public class Squad
    {
        public List<Soldier> Soldiers { get; set; } = new List<Soldier>();

        public Soldier SquadLeader { get; set; }
    }
}
