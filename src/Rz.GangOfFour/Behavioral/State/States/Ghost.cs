using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.State.States
{
    public class Ghost:IState
    {
        public void Heal(int hitPoints)
        {
            //can't be healed
        }

        public void Damage(int hitPoints)
        {
            //can't be damaged
        }

        public int HitPoints => 1;
        public IState NextState => null;
    }
}
