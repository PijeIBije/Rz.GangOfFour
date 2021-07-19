using System;
using System.Collections.Generic;
using System.Text;

namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class HitHandler
    {
        private Handlers handlers;

        public HitHandler(Handlers handlers)
        {
            this.handlers = handlers;
        }

        public void Handle(HitData hitData)
        {
            if (hitData.ObjectHit.ArmorValue > 0)
            {
                handlers.Get<ArmorPenetrationHandler>().Handle(hitData);
            }
            else
            {
                handlers.Get<DamageHandler>().Handle(hitData);
            }
        }
    }
}

