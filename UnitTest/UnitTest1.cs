using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1

    {
        LogicClass test = new LogicClass();

        [TestMethod]
        public void TestMethod1()
        {
            int testResult = test.Spin();

            Assert.IsTrue(test.Spin() > 0);

        }
        [TestMethod]
        public void TestMethod2()
        {
            RussianRoulette.LogicClass testshoot = new RussianRoulette.LogicClass();

            int testResultshoot = testshoot.ShootAway();

            Assert.IsTrue(testResultshoot <= 4 && testResultshoot > 0);

        }
        [TestMethod]
        public void TestMethod3()
        {
            RussianRoulette.LogicClass testShootAway = new RussianRoulette.LogicClass();

            int testResultShootAway = testShootAway.Spin();

            Assert.IsTrue(testResultShootAway < 7 && testResultShootAway > 0);

        }

    }
}





