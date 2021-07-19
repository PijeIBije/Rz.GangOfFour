namespace Rz.GangOfFour.Creational.Prototype.Equipment.Helmets
{
    public class KevlarHelmet:IHelmet
    {
        public IHelmet Clone() => new KevlarHelmet();
    }
}
