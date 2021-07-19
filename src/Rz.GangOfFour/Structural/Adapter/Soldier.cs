namespace Rz.GangOfFour.Structural.Adapter
{
    public class Soldier
    {
        public int Health { get; private set; } = 100;

        public bool IsDead => Health == 0;

        public void ApplyDamage(int damage)
        {
            Health -= damage;
        }
    }
}
