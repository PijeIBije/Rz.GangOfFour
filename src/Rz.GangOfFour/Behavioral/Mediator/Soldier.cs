using Rz.GangOfFour.Behavioral.Mediator.Messages;

namespace Rz.GangOfFour.Behavioral.Mediator
{
    public class Soldier
    {
        private readonly Mediator mediator;

        public Soldier(string team, Mediator mediator)
        {
            Team = team;

            this.mediator = mediator;
        }
        public string Team { get;}

        public int Morale { get; private set; }

        public void OnSoldierKilled(KilledBy killedBy)
        {
            if (killedBy.Killer.Team == Team) 
                Morale++;
            else
            {
                Morale--;
            }
        }

        public bool Dead { get; private set; }

        public void IsKilledBy(Soldier killer)
        {
            Dead = true;

            mediator.Send(new KilledBy(this,killer));
        }
    }
}
