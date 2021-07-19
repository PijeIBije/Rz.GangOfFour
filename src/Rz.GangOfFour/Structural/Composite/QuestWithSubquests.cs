using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Structural.Composite
{
    public class QuestWithSubquests:IQuest
    {
        public QuestWithSubquests(string requirements,IEnumerable<IQuest> subQuests)
        {
            Requirements = requirements;
            SubQuests = subQuests;
        }

        public IEnumerable<IQuest> AllQuests => new IQuest[]{this}.Union(SubQuests.SelectMany(x=>x.AllQuests));

        public IEnumerable<IQuest> SubQuests { get; }
        public string Requirements { get; }
        public bool Completed => SubQuests.All(x => x.Completed);
    }
}
