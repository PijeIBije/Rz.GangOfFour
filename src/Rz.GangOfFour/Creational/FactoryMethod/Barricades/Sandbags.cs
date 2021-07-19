namespace Rz.GangOfFour.Creational.FactoryMethod.Barricades
{
    public class Sandbags:IBarricade
    {
        public string Team { get; }

        public Sandbags(string team)
        {
            Team = team;
        }
    }
}
