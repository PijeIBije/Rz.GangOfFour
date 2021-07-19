namespace Rz.GangOfFour.Creational.Prototype.Equipment.Uniforms
{
    public class BattleDressUniform:IUniform
    {
        public IUniform Clone() => new BattleDressUniform();
    }
}
