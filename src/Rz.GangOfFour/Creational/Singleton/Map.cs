namespace Rz.GangOfFour.Creational.Singleton
{
    public class Map
    {
        private Map()
        {
            
        }

        private static Map instance;

        public static Map Current => instance ??= new Map();
    }
}
