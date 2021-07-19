namespace Rz.GangOfFour.Creational.Builder
{
    public interface ISoldierBuilder
    {
        void SetHelmet(Soldier soldier);

        void SetWeapons(Soldier soldier);

        void SetUniform(Soldier soldier);
    }
}
