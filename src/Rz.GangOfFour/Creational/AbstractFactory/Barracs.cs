namespace Rz.GangOfFour.Creational.AbstractFactory
{
    public class Barracs
    {
        private readonly IEquipmentFactory equipmentFactory;

        public Barracs(IEquipmentFactory equipmentFactory)
        {
            this.equipmentFactory = equipmentFactory;
        }

        public Soldier Train()
        {
            var soldier = new Soldier
            {
                Helmet = equipmentFactory.CreateHelmet(),
                Rifle = equipmentFactory.CreateRifle(),
                Sidearm = equipmentFactory.CreateSidearm(),
                Uniform = equipmentFactory.CreateUniform()
            };


            return soldier;
        }
    }
}
