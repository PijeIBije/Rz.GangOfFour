using System;

namespace Rz.GangOfFour.Behavioral.Strategy.DamageCalculationStrategies
{
    public class DoubleDamage:IDamageCalculation
    {
        public int CalculateDamage(int damage, int armor) => Math.Max(damage * 2 - armor, 0);
    }
}
