using Rz.GangOfFour.Creational.AbstractFactory.Equipment;

namespace Rz.GangOfFour.Creational.AbstractFactory
{
    public interface IEquipmentFactory
    {
        IHelmet CreateHelmet();

        IRifle CreateRifle();

        IUniform CreateUniform();

        ISidearm CreateSidearm();
    }
}
