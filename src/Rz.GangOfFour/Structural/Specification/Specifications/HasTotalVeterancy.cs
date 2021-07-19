using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Structural.Specification.Specifications
{
    public class HasTotalVeterancy:SpecificationBase<Squad>
    {
        private readonly int totalVeterancy;

        public HasTotalVeterancy(int totalVeterancy)
        {
            this.totalVeterancy = totalVeterancy;
        }

        protected override bool CheckSingle(Squad item)
        {
            return item.Soldiers.Sum(soldier => soldier.Veterancy)+(item.SquadLeader?.Veterancy??0) >= totalVeterancy;
        }
    }
}
