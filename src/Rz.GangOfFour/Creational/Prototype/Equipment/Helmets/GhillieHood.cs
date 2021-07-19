namespace Rz.GangOfFour.Creational.Prototype.Equipment.Helmets
{
    public class GhillieHood:IHelmet
    {
        public IHelmet Clone() => new GhillieHood();
    }
}
