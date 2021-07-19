using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.Observer.Buildings;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class Observer
    {
        [TestMethod]
        public void Demo()
        {
            var powerPlant = new PowerPlant();

            powerPlant.SetPower(100);

            var tankFactory = new TankFactory();

            var searchlight = new Searchlight();

            powerPlant.PowerPlantDependants.Add(tankFactory);
            powerPlant.PowerPlantDependants.Add(searchlight);

            tankFactory.BeginProduction();
            searchlight.TurnOn();

            powerPlant.SetPower(50);

            Assert.IsFalse(tankFactory.ProductionInProgress);
            Assert.IsTrue(searchlight.IsOn);
        }
    }
}
