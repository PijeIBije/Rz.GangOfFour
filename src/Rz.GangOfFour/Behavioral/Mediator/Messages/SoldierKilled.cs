namespace Rz.GangOfFour.Behavioral.Mediator.Messages
{
    public class KilledBy:MessageBase
    {
        public Soldier Killer { get;}

        public KilledBy(Soldier source, Soldier killer) : base(source)
        {
            Killer = killer;
        }
    }
}
