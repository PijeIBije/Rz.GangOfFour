namespace Rz.GangOfFour.Creational.Prototype.Equipment.Sidearms
{
    public class M1911:ISidearm
    {
        public ISidearm Clone() => new M1911();
    }
}
