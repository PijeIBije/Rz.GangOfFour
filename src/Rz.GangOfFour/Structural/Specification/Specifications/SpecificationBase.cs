using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Structural.Specification.Specifications
{
    public abstract class SpecificationBase<T>
    {
        public IEnumerable<T> Check(IEnumerable<T> items)
        {
            return items.Where(CheckSingle);
        }

        protected abstract bool CheckSingle(T item);

        public CombinedSpecification<T> And(SpecificationBase<T> other)
        {
            return new CombinedSpecification<T>(x => CheckSingle(x) && other.CheckSingle(x));
        }

        public CombinedSpecification<T> Or(SpecificationBase<T> other)
        {
            return new CombinedSpecification<T>(x => CheckSingle(x) || other.CheckSingle(x));
        }
    }
}
