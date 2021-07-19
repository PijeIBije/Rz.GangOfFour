namespace Rz.GangOfFour.Creational.Prototype.Equipment.Uniforms
{
    public class GhillieSuit:IUniform
    {
        public IUniform Clone() => new GhillieSuit();
    }
}
