using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rz.GangOfFour.Behavioral.ChainOfResponsibility;
using Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers;

namespace Rz.GangOfFour.Demos.Behavioral
{
    [TestClass]
    public class ChainOfResponsibility
    {
        private ShotPathHandler shotPathHandler;
        private GameObjects gameObjects;

        [TestInitialize]
        public void Initialize()
        {
            var handlers = new Handlers();
            gameObjects = new GameObjects();

            var damageHandler = new DamageHandler();
            var armorPenetrationHandler = new ArmorPenetrationHandler(handlers);
            shotPathHandler= new ShotPathHandler(handlers,gameObjects);
            var hitHandler =new HitHandler(handlers);

            handlers.Add(damageHandler);
            handlers.Add(armorPenetrationHandler);
            handlers.Add(shotPathHandler);
            handlers.Add(hitHandler);
            
        }

        /// <summary>
        /// The pattern is implemented in form of several projectile handlers, each performing logic related to stage
        /// of the projectile's travel and choosing appropriate next handler depending on the calculations.
        /// </summary>
        [TestMethod]
        public void Demo()
        {
            var soldier1 = new Soldier {Position = new Vector(0, 0)};

            var tank = new Tank {Position = new Vector( 100, 100)};

            var soldier2 = new Soldier {Position = new Vector(150, 50)};

            gameObjects.AddRange(new GameObject[]{soldier1,soldier2,tank});

            var shotData = soldier1.ShootAt(tank.Position);

            shotPathHandler.Handle(shotData);

            /*
             * Exepected projectile travel is:
             * -Fired by soldier 1
             * -Failed to penetrate tank
             * -Ricochet towards soldier2 loosing some force
             * -Wounding soldier2
             */

            Assert.AreEqual(soldier2.Health,50);
        }
    }
}
