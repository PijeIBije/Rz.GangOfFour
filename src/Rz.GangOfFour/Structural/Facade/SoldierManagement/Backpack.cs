using System.Collections.Generic;

namespace Rz.GangOfFour.Structural.Facade.SoldierManagement
{
    public class Backpack
    {
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();

        public void RemoveWeapon(Weapon weapon)
        {
            Weapons.Remove(weapon);
        }
    }
}
