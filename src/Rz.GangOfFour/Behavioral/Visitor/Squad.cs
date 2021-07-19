using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Behavioral.Visitor
{
    public class Squad
    {
        public IReadOnlyList<Soldier> Soldiers { get; }

        public Squad(List<Soldier> soldiers)
        {
            Soldiers = soldiers.ToList();
        }

        public int VeterancyLevel { get; set; }

        public void Apply(Promotion promotion)
        {
            promotion.Visit(this);

            foreach (var soldier in Soldiers)
            {
                soldier.Apply(promotion);
            }
        }
    }
}
