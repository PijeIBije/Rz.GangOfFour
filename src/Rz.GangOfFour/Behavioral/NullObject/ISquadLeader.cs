using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.NullObject
{
    public interface ISquadLeader
    {
        string PlayerName { get; }

        int Veterancy { get; }

        public void SetVeterancy(int veterancy);
    }
}
