using System.Collections.Generic;
using System.Linq;

namespace Rz.GangOfFour.Structural.Flyweight
{
    public class Stats
    {
        private static readonly Dictionary<string,Stats> parsedInstances = new Dictionary<string, Stats>();

        public static Stats Get(string statsString)
        {
            if (!parsedInstances.TryGetValue(statsString, out Stats instance))
            {
                instance = new Stats(statsString);
                parsedInstances.Add(statsString,instance);
            }

            return instance;
        }

        public int Str { get; }

        public int Int { get; }

        public int Dex { get; }

        public Stats(string statsString)
        {
            var statsStringSplit = statsString.Split(",").Select(x => x.Trim()).ToArray();

            Str = int.Parse(statsStringSplit[0]);
            Int = int.Parse(statsStringSplit[1]);
            Dex = int.Parse(statsStringSplit[2]);
        }
    }
}
