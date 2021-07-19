namespace Rz.GangOfFour.Behavioral.Visitor
{
    public class Soldier
    {
        public float Damage { get; set; } = 1;

        public void Apply(Promotion promotion)
        {
            promotion.Visit(this);
        }
    }
}
