using Rz.GangOfFour.Creational.Builder.Equipment;

namespace Rz.GangOfFour.Creational.Builder
{
    public class Soldier
    {
        public IHelmet Helmet { get; set; }

        public IUniform Uniform { get; set; }

        public IRifle Rifle { get; set; }

        public ISidearm Sidearm { get; set; }
    }
}
