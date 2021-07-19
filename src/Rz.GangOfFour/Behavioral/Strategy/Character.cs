using Rz.GangOfFour.Behavioral.Strategy.DamageCalculationStrategies;

namespace Rz.GangOfFour.Behavioral.Strategy
{
    public class Character
    {
        private readonly IDamageCalculation damageCalculation;

        public Character(
            int health,
            int armor,
            IDamageCalculation damageCalculation)
        {
            Health = health;
            Armor = armor;
            this.damageCalculation = damageCalculation;
        }

        public int Health { get; private set; }

        public int Armor { get; }

        public void ApplyDamage(int damage)
        {
            Health -= damageCalculation.CalculateDamage(damage, Armor);
        }
    }
}
