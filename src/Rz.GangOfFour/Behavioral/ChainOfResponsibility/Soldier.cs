using Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers;

namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility
{
    public class Soldier:GameObject
    {
        public Soldier()
        {
            Health = 100;
            ArmorValue = 0;
        }

        public ShotData ShootAt(Vector target)
        {
            return new ShotData(target,this,100);
        }
    }
}
