using Rz.GangOfFour.Creational.Prototype.Equipment;

namespace Rz.GangOfFour.Creational.Prototype
{
    public class Soldier
    {
        public IHelmet Helmet { get; set; }

        public IUniform Uniform { get; set; }

        public IRifle Rifle { get; set; }

        public ISidearm Sidearm { get; set; }

        public Soldier Clone()
        {
            return new Soldier
            {
                Sidearm = Sidearm.Clone(),
                Rifle = Rifle.Clone(),
                Helmet = Helmet.Clone(),
                Uniform = Uniform.Clone()
            };
        }
    }
}
