using Rz.GangOfFour.Creational.AbstractFactory.Equipment;

namespace Rz.GangOfFour.Creational.AbstractFactory
{
    public class Soldier
    {
        public IHelmet Helmet { get; set; }

        public IUniform Uniform { get; set; }

        public IRifle Rifle { get; set; }

        public ISidearm Sidearm { get; set; }
    }
}
