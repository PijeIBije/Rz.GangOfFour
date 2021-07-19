namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class HitData
    {
        public GameObject ObjectHit { get; }

        public GameObject Source { get; }

        public int Force { get; }

        public HitData(
            GameObject objectHit,
            GameObject source,
            int force)
        {
            ObjectHit = objectHit;
            Source = source;
            Force = force;
        }
    }
}
