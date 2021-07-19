using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Structural.Decorator;
using Rz.GangOfFour.Structural.Facade;
using Rz.GangOfFour.Structural.Facade.SoldierManagement;
using Soldier = Rz.GangOfFour.Structural.Facade.SoldierManagement.Soldier;

namespace Rz.GangOfFour.Demos.Structural
{
    [TestClass]
    public class Facade
    {
        [TestMethod]
        public void Demo()
        {
            var soldier1 = new Soldier(1);
            soldier1.Backpack.Weapons.Add(new Weapon { Name = "M4" });

            var soldier2 = new Soldier(2);

            var map = new Map
            {
                Soldiers = new List<Soldier>
                {
                    soldier1,
                    soldier2
                }
            };
            var weaponShop = new WeaponShop();

            var soldierManagementFacade = new SoldierManagementFacade(weaponShop, map);

            soldierManagementFacade.SoldierEquipWeapon(1, "M4");

            Assert.AreEqual(soldier1.EquipmentSlots[Soldier.Slot.Weapon].Name, "M4");
            Assert.IsFalse(soldier1.Backpack.Weapons.Any());

            soldierManagementFacade.SoldierEquipWeapon(2, "M4");

            Assert.AreEqual(soldier2.EquipmentSlots[Soldier.Slot.Weapon].Name, "M4");
            Assert.AreEqual(weaponShop.WeaponsSold,1);

        }
    }
}
