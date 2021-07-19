namespace Rz.GangOfFour.Behavioral.Memento
{
    public class Soldier
    {
        public int HealthMax { get; private set; } = 100;

        public int HealthLost { get; private set; }

        public int HealthRemaining { get; private set; }

        public bool IsWounded { get; private set; }
        
        public bool IsHealthy { get; private set; }

        private void CalculateStats()
        {
            HealthRemaining = HealthMax - HealthLost;

            IsWounded = HealthRemaining < 30;

            IsHealthy = HealthLost < 30;
        }

        public SoldierState GetState()
        {
            return new SoldierState
            {
                HealthLost = HealthLost,
                HealthMax = HealthMax
            };
        }

        public void SetState(SoldierState soldierState)
        {
            HealthMax = soldierState.HealthMax;
            HealthLost = soldierState.HealthLost;

            CalculateStats();
        }

        public void ApplyDamage(int damage)
        {
            HealthLost += damage;

            CalculateStats();
        }
    }
}
