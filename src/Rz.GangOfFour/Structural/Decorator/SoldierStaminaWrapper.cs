namespace Rz.GangOfFour.Structural.Decorator
{
    public class SoldierStaminaWrapper:ISoldier
    {
        private readonly Soldier soldier;

        public int Stamina { get; private set; }

        public SoldierStaminaWrapper(Soldier soldier, int stamina)
        {
            this.soldier = soldier;
            Stamina = stamina;
        }

        public int Attack()
        {
            Stamina--;
            if (Stamina > 0) return soldier.Attack();
            return (int)(soldier.Attack() * 0.5);
        }
    }
}
