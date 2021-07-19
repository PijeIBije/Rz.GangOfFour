using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.State.States
{
    public class Undead:IState
    {
        public void Heal(int hitPoints)
        {
            //cant be healed
        }

        public void Damage(int hitPoints)
        {
            HitPoints -= hitPoints;
        }

        public int HitPoints { get; private set; } = 100;
        public IState NextState => new Ghost();
    }
}
