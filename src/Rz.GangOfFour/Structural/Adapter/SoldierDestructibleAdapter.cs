namespace Rz.GangOfFour.Structural.Adapter
{
    public class SoldierDestructibleAdapter:IDestructible
    {
        private readonly Soldier soldier;

        public SoldierDestructibleAdapter(Soldier soldier)
        {
            this.soldier = soldier;
        }

        public void Destroy()
        {
            soldier.ApplyDamage(soldier.Health);
        }
    }
}
