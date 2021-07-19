using System;
using Rz.GangOfFour.Creational.FactoryMethod.Barricades;

namespace Rz.GangOfFour.Creational.FactoryMethod
{
    public class Soldier
    {
        public string Team { get; }
        private readonly Func<string, IBarricade> createBarricadeFunc;

        public Soldier(string team, Func<string,IBarricade> createBarricadeFunc)
        {
            Team = team;
            this.createBarricadeFunc = createBarricadeFunc;
        }

        public IBarricade PlaceBarricade()
        {
            return createBarricadeFunc(Team);
        }
    }
}
