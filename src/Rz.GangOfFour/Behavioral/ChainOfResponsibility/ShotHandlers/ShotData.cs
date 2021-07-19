namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class ShotData
    {
        public Vector Target { get; }
        public GameObject Source { get; }
        public int Force { get; }

        public ShotData(
            Vector target, 
            GameObject source,
            int force)
        {
            Target = target;
            Source = source;
            Force = force;
        }
    }
}
