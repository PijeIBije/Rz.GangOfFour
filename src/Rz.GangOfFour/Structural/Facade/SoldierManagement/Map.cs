using System.Collections.Generic;

namespace Rz.GangOfFour.Structural.Facade.SoldierManagement
{
    public class Map
    {
        public List<Soldier> Soldiers { get; set; } = new List<Soldier>
        {
            new Soldier(1), new Soldier(2)
        };
    }
}
