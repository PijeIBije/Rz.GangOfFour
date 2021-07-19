using System;

namespace Rz.GangOfFour.Behavioral.Strategy.DamageCalculationStrategies
{
    public class Default:IDamageCalculation
    {
        public int CalculateDamage(int damage, int armor) => Math.Max(damage - armor, 0);
    }
}
