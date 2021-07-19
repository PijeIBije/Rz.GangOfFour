using Rz.GangOfFour.Behavioral.Mediator.Messages;

namespace Rz.GangOfFour.Behavioral.Mediator
{
    public class Team
    {
        public string Name { get; }


        public Team(string name)
        {
            Name = name;
        }

        public int Casualties { get; private set; }

        public void OnSoldierKilled(KilledBy killedBy)
        {
            if (((Soldier)killedBy.Source).Team == Name) Casualties++;
        }
    }
}
