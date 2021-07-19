namespace Rz.GangOfFour.Structural.Facade.SoldierManagement
{
    public class WeaponShop
    {
        public int WeaponsSold { get; private set; }
        public Weapon BuyWeapon(string name)
        {
            WeaponsSold++;
            return new Weapon {Name = name};
        }
    }
}
