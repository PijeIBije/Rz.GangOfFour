using System.Collections.Generic;

namespace Rz.GangOfFour.Structural.Facade.SoldierManagement
{
    public class Soldier
    {
        public Soldier(int id)
        {
            Id = id;
        }

        public int Id { get;  }
        public Backpack Backpack { get; } = new Backpack();

        public enum Slot
        {
            Weapon,
            Uniform,
            Helmet
        }

        public Dictionary<Slot,Item> EquipmentSlots { get; set; } = new Dictionary<Slot,Item>();
    }
}
