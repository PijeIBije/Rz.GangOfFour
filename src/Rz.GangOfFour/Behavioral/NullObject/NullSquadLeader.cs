using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.NullObject
{
    public class NullSquadLeader:ISquadLeader
    {
        public string PlayerName => "None";
        public int Veterancy => 0;
        public void SetVeterancy(int veterancy)
        {
            //no operation
        }
    }
}
