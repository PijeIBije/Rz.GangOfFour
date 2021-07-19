using Rz.GangOfFour.Creational.AbstractFactory.Equipment;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Helmets;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Rifles;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Sidearms;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Uniforms;

namespace Rz.GangOfFour.Creational.AbstractFactory
{
    public class SniperEquipmentFactory:IEquipmentFactory
    {
        public IHelmet CreateHelmet()=> new GhillieHood();

        public IRifle CreateRifle() => new M82();

        public IUniform CreateUniform()=> new GhillieSuit();

        public ISidearm CreateSidearm()=> new M1911();
    }
}
