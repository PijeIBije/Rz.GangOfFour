namespace Rz.GangOfFour.Behavioral.Visitor
{
    public class Promotion
    {
        public void Visit(Squad squad)
        {
            squad.VeterancyLevel++;
        }

        public void Visit(Soldier soldier)
        {
            soldier.Damage *= 1.1f;
        }
    }
}
