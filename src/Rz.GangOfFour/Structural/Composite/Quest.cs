using System.Collections.Generic;

namespace Rz.GangOfFour.Structural.Composite
{
    public class Quest:IQuest
    {
        public Quest(string requirements)
        {
            Requirements = requirements;
        }

        public string Requirements { get; }
        public bool Completed { get; set; }
        public IEnumerable<IQuest> AllQuests => new[] {this};
    }
}
