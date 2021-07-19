namespace Rz.GangOfFour.Creational.Builder
{
    public class Barracs
    {
        private readonly ISoldierBuilder soldierBuilder;

        public Barracs(ISoldierBuilder soldierBuilder)
        {
            this.soldierBuilder = soldierBuilder;
        }

        public Soldier Train()
        {
            var soldier = new Soldier();
        
            soldierBuilder.SetHelmet(soldier);
            soldierBuilder.SetUniform(soldier);
            soldierBuilder.SetWeapons(soldier);


            return soldier;
        }
    }
}
