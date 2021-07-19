namespace Rz.GangOfFour.Behavioral.Observer.Buildings
{
    public class TankFactory:IPowerPlantDependant
    {
        public bool ProductionInProgress { get; private set; }

        public void BeginProduction()
        {
            ProductionInProgress = true;
        }

        public void Update(PowerPlant powerPlant)
        {
            if (powerPlant.ProducedPower < 100) ProductionInProgress = false;
        }
    }
}
