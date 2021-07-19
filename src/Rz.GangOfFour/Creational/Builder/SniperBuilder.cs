using Rz.GangOfFour.Creational.Builder.Equipment.Helmets;
using Rz.GangOfFour.Creational.Builder.Equipment.Rifles;
using Rz.GangOfFour.Creational.Builder.Equipment.Sidearms;
using Rz.GangOfFour.Creational.Builder.Equipment.Uniforms;

namespace Rz.GangOfFour.Creational.Builder
{
    public class SniperBuilder:ISoldierBuilder
    {
        public void SetHelmet(Soldier soldier)
        {
            soldier.Helmet = new GhillieHood();
        }

        public void SetWeapons(Soldier soldier)
        {
            soldier.Rifle = new M82();
            soldier.Sidearm = new M1911();
        }

        public void SetUniform(Soldier soldier)
        {
            soldier.Uniform = new GhillieSuit();
        }
    }
}
