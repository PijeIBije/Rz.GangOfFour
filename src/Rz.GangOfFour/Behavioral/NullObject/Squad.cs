using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.NullObject
{
    public class Squad
    {
        private readonly bool useNullValueObject;

        public Squad(bool useNullValueObject)
        {
            this.useNullValueObject = useNullValueObject;
        }

        private ISquadLeader squadLeader;

        public ISquadLeader SquadLeader
        {
            get => squadLeader ?? (useNullValueObject ? new NullSquadLeader() : null);
            set => squadLeader = value;
        }
    }
}
