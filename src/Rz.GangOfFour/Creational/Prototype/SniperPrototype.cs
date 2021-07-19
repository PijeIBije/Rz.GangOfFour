using Rz.GangOfFour.Creational.Prototype.Equipment.Helmets;
using Rz.GangOfFour.Creational.Prototype.Equipment.Rifles;
using Rz.GangOfFour.Creational.Prototype.Equipment.Sidearms;
using Rz.GangOfFour.Creational.Prototype.Equipment.Uniforms;

namespace Rz.GangOfFour.Creational.Prototype
{
    public class SniperPrototype:Soldier
    {
        public SniperPrototype()
        {
            Helmet = new GhillieHood();
            Uniform = new GhillieSuit();
            Rifle = new M82();
            Sidearm = new M1911();
        }
    }
}
