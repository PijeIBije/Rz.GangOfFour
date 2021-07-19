namespace Rz.GangOfFour.Creational.Prototype
{
    public class Barracs
    {
        private readonly Soldier soldierPrototype;

        public Barracs(Soldier soldierPrototype)
        {
            this.soldierPrototype = soldierPrototype;
        }

        public Soldier Train()
        {
            var soldier = soldierPrototype.Clone();

            return soldier;
        }
    }
}
