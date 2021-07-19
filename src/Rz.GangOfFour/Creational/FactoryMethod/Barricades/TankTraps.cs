namespace Rz.GangOfFour.Creational.FactoryMethod.Barricades
{
    public class TankTraps:IBarricade
    {
        public string Team { get; }

        public TankTraps(string team)
        {
            Team = team;
        }
    }
}
