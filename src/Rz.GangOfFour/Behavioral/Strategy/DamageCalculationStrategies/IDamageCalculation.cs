namespace Rz.GangOfFour.Behavioral.Strategy.DamageCalculationStrategies
{
    public interface IDamageCalculation
    {
        int CalculateDamage(int damage, int armor);
    }
}
