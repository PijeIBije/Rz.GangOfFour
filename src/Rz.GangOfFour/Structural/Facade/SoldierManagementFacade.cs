using System.Linq;
using Rz.GangOfFour.Structural.Facade.SoldierManagement;

namespace Rz.GangOfFour.Structural.Facade
{
    public class SoldierManagementFacade
    {
        private readonly WeaponShop weaponShop;
        private readonly Map map;

        public SoldierManagementFacade(
            WeaponShop weaponShop,
            Map map)
        {
            this.weaponShop = weaponShop;
            this.map = map;
        }
        public void SoldierEquipWeapon(int soldierId, string weaponName)
        {
            var soldier = map.Soldiers.Single(x => x.Id == soldierId);

            var weaponToEquip = soldier.Backpack.Weapons.FirstOrDefault(x => x.Name == weaponName);
            if (weaponToEquip != default)
            {
                soldier.Backpack.Weapons.Remove(weaponToEquip);
            }
            else
            {
                weaponToEquip = weaponShop.BuyWeapon(weaponName);
            }

            soldier.EquipmentSlots[Soldier.Slot.Weapon] = weaponToEquip;
        }
    }
}
