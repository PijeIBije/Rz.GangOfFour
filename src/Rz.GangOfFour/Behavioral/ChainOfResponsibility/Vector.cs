namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility
{
    public class Vector
    {
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get;  }

        public bool Equals(Vector vector)
        {
            return vector.X == X && vector.Y == Y;
        }
    }
}
