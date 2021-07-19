using Rz.GangOfFour.Creational.Prototype.Equipment.Helmets;
using Rz.GangOfFour.Creational.Prototype.Equipment.Rifles;
using Rz.GangOfFour.Creational.Prototype.Equipment.Sidearms;
using Rz.GangOfFour.Creational.Prototype.Equipment.Uniforms;

namespace Rz.GangOfFour.Creational.Prototype
{
    public class RiflemanPrototype:Soldier
    {
        public RiflemanPrototype()
        {
            Helmet = new KevlarHelmet();
            Uniform = new BattleDressUniform();
            Rifle = new M4();
            Sidearm = new M1911();
        }
    }
}
