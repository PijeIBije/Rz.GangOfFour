using System;

namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class ArmorPenetrationHandler
    {
        private readonly Handlers handlers;

        public ArmorPenetrationHandler(Handlers handlers)
        {
            this.handlers = handlers;
        }

        public void Handle(HitData hitData)
        {
            var forceRemaining = hitData.Force - hitData.ObjectHit.ArmorValue;

            if (forceRemaining >= 0)
            {
                handlers.Get<DamageHandler>().Handle(new HitData(hitData.ObjectHit,hitData.Source,forceRemaining));
            }
            else
            {
                var forceDeflected = forceRemaining * -1;

                handlers.Get<ShotPathHandler>().Handle(new ShotData(
                    CalculateRicochet(forceDeflected,hitData.ObjectHit,hitData.Source),
                    hitData.Source,
                    forceDeflected));
            }
        }

        private Vector CalculateRicochet(int forceDeflected, GameObject objectHit, GameObject source)
        {
            return new Vector(objectHit.Position.X+forceDeflected,objectHit.Position.Y-forceDeflected);
        }
    }
}
