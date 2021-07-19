using System;
using System.Collections.Generic;
using System.Text;
using Rz.GangOfFour.Behavioral.State.States;

namespace Rz.GangOfFour.Behavioral.State
{
    public class Character
    {
        public IState State { get; set; }

        public Character()
        {
            State = new Alive();
        }

        public int HitPoints => State.HitPoints;

        public void Damage(int hitPoints)
        {
            State.Damage(hitPoints);
            if (State.HitPoints <= 0) State = State.NextState;
        }

        public void Heal(int hitPoints) => State.Heal(hitPoints);
    }
}
