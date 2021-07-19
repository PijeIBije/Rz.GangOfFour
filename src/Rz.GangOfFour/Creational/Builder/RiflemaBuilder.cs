using Rz.GangOfFour.Creational.Builder.Equipment.Helmets;
using Rz.GangOfFour.Creational.Builder.Equipment.Rifles;
using Rz.GangOfFour.Creational.Builder.Equipment.Sidearms;
using Rz.GangOfFour.Creational.Builder.Equipment.Uniforms;

namespace Rz.GangOfFour.Creational.Builder
{
    public class RiflemaBuilder:ISoldierBuilder
    {
        public void SetHelmet(Soldier soldier)
        {
            soldier.Helmet = new KevlarHelmet();
        }

        public void SetWeapons(Soldier soldier)
        {
            soldier.Rifle = new M4();
            soldier.Sidearm = new M1911();
        }

        public void SetUniform(Soldier soldier)
        {
            soldier.Uniform = new BattleDressUniform();
        }
    }
}
