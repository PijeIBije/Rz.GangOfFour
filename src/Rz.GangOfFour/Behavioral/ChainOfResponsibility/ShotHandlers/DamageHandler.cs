namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class DamageHandler
    {
        public void Handle(HitData hitData)
        {
            hitData.ObjectHit.Health -= hitData.Force;
        }
    }
}
