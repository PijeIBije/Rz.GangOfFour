using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rz.GangOfFour.Structural.Specification.Specifications
{
    public class NoAbleSquadLeader:SpecificationBase<Squad>
    {
        protected override bool CheckSingle(Squad item)
        {
            return item.SquadLeader == null || item.SquadLeader.IsWounded;
        }
    }
}
