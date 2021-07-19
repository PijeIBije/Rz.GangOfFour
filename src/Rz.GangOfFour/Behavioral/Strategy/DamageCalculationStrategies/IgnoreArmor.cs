using System;

namespace Rz.GangOfFour.Behavioral.Strategy.DamageCalculationStrategies
{
    public class IgnoreArmorPercentage:IDamageCalculation
    {
        private readonly int armorPercentageToIgnore;

        public IgnoreArmorPercentage(int armorPercentageToIgnore)
        {
            this.armorPercentageToIgnore = armorPercentageToIgnore;
        }

        public int CalculateDamage(int damage, int armor)
        {
            var reducedArmor = (int) (armor * (100 - armorPercentageToIgnore) / 100);

            return Math.Max(0, damage - reducedArmor);
        }
    }
}
