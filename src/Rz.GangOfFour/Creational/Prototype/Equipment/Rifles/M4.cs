namespace Rz.GangOfFour.Creational.Prototype.Equipment.Rifles
{
    public class M4:IRifle
    {
        public IRifle Clone() => new M4();
    }
}
