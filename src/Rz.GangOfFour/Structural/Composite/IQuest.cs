using System.Collections.Generic;

namespace Rz.GangOfFour.Structural.Composite
{
    public interface IQuest
    {
        string Requirements { get; }

        bool Completed { get; }

        IEnumerable<IQuest> AllQuests { get; }
    }
}
