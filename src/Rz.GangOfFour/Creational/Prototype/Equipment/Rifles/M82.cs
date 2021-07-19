namespace Rz.GangOfFour.Creational.Prototype.Equipment.Rifles
{
    public class M82:IRifle
    {
        public IRifle Clone() => new M82();
    }
}
