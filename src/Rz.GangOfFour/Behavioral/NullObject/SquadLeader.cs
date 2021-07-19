using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.NullObject
{
    public class SquadLeader:ISquadLeader
    {
        public SquadLeader(string playerName)
        {
            PlayerName = playerName;
        }

        public string PlayerName { get;}

        public int Veterancy { get; private set; }

        public void SetVeterancy(int veterancy)
        {
            Veterancy = veterancy;
        }
    }
}
