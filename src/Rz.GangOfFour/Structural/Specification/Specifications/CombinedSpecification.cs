using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Structural.Specification.Specifications
{
    public class CombinedSpecification<T>:SpecificationBase<T>
    {
        private readonly Func<T, bool> predicate;

        public CombinedSpecification(Func<T,bool> predicate)
        {
            this.predicate = predicate;
        }
        protected override bool CheckSingle(T item)
        {
            return predicate(item);
        }
    }
}
