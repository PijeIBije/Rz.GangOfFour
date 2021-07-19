using System;

namespace Rz.GangOfFour.Structural.Adapter
{
    public class Wall:IDestructible
    {
        public bool IsDestroyed { get; private set; }
        public void Destroy()
        {
            IsDestroyed = true;
        }
    }
}
