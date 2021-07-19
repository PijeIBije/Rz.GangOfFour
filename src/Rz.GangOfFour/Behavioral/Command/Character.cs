using System;

namespace Rz.GangOfFour.Behavioral.Command
{
    public class Character
    {
        public int Mana { get; private set; } = 10;

        public int PositionY { get; private set; } = 0;

        public int PositionX { get; private set; } = 0;

        public void Move(int vertical, int horizontal)
        {
            PositionX += horizontal;
            PositionY += vertical;
        }
        

        public void CastSpell(string spell)
        {
            Mana -= spell switch
            {
                "FireBall" => 2,
                "MagicMissile" => 1,
                _ => throw new Exception("Unknown spell")
            };
        }
    }
}
