namespace Rz.GangOfFour.Behavioral.Observer.Buildings
{
    public class Searchlight:IPowerPlantDependant
    {
        public void Update(PowerPlant powerPlant)
        {
            if (powerPlant.ProducedPower < 25) IsOn = false;
        }

        public void TurnOn() => IsOn = true;

        public bool IsOn { get; private set; } 
    }
}
