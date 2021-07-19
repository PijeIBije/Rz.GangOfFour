using System.Collections.Generic;

namespace Rz.GangOfFour.Behavioral.Observer.Buildings
{
    public class PowerPlant
    {
        public List<IPowerPlantDependant> PowerPlantDependants = new List<IPowerPlantDependant>();

        public int ProducedPower { get; set; }

        public void SetPower(int power)
        {
            ProducedPower = power;
            foreach (var powerPlantDependant in PowerPlantDependants)
            {
                powerPlantDependant.Update(this);
            }
        }
    }
}
