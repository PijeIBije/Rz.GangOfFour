using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Creational.Singleton;

namespace Rz.GangOfFour.Demos.Creational
{
    [TestClass]
    public class Singleton
    {
        /// <summary>
        /// Instance constructor is private. 
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            //won't compile => private constructor
            //var map = new Map();

            var mapReference1 = Map.Current;

            var mapReference2 = Map.Current;

            Assert.AreEqual(mapReference1,mapReference2);
        }
    }
}
