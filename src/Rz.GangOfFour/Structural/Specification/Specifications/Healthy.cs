using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Structural.Specification.Specifications
{
    public class Healthy : SpecificationBase<Squad>
    {
        protected override bool CheckSingle(Squad item)
        {
            return (item.SquadLeader == null ||
                   !item.SquadLeader.IsWounded) && item.Soldiers.All(soldier => !soldier.IsWounded);
        }
    }
}
