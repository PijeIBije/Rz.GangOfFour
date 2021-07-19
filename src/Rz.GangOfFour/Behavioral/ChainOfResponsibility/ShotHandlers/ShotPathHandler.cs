using System;
using System.Linq;

namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class ShotPathHandler
    {
        private readonly Handlers handlers;
        private readonly GameObjects gameObjects;

        public ShotPathHandler(Handlers handlers, GameObjects gameObjects)
        {
            this.handlers = handlers;
            this.gameObjects = gameObjects;
        }

        public void Handle(ShotData shotData)
        {
            var objectHit = GetCollidedObject(shotData.Target);

            if (objectHit != null)
            {
                var hitData = new HitData(objectHit,shotData.Source,shotData.Force);

                handlers.Get<HitHandler>().Handle(hitData);
            }
        }

        private GameObject GetCollidedObject(Vector target)
        {
            var objectHit = gameObjects.SingleOrDefault(x => x.Position.Equals(target));

            return objectHit;
        }
    }
}
