using System.Collections.Generic;

namespace Rz.GangOfFour.Behavioral.Template
{
    public class Room
    {
        public List<object> GameObjects = new List<object>();

        public void AddObject(object gameObject)
        {
            GameObjects.Add(gameObject);
        }
    }
}
