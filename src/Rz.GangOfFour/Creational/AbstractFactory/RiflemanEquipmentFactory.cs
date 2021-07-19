using Rz.GangOfFour.Creational.AbstractFactory.Equipment;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Helmets;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Rifles;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Sidearms;
using Rz.GangOfFour.Creational.AbstractFactory.Equipment.Uniforms;

namespace Rz.GangOfFour.Creational.AbstractFactory
{
    public class RiflemanEquipmentFactory:IEquipmentFactory
    {
        public IHelmet CreateHelmet()=> new KevlarHelmet();

        public IRifle CreateRifle()=> new M4();

        public IUniform CreateUniform()=> new BattleDressUniform();

        public ISidearm CreateSidearm() => new M1911();
    }
}
