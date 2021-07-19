using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.State.States
{
    public interface IState
    {
        void Heal(int hitPoints);

        void Damage(int hitPoints);

        int HitPoints { get; }

        public IState NextState { get; }
    }
}
