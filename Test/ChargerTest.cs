using System;
using Chargers;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ChargerTest
    {
        [TestMethod]
        public void CalculateChargingTimeCarZeroCap()
        {
            ICharger crg=ChargerFactory.GetCharger(ChargerTypes.Car);
            double actRes=crg.CalculateChargingTime(0);
            double expRes=0;
            Assert.AreEqual(expRes, actRes);
        }
        [TestMethod]
        public void CalculateChargingTimeWallZeroCap()
        {
            ICharger crg = ChargerFactory.GetCharger(ChargerTypes.Wall);
            double actRes = crg.CalculateChargingTime(0);
            double expRes = 0;
            Assert.AreEqual(expRes, actRes);
        }
        [TestMethod]
        public void CalculateChargingTimePowerBZeroCap()
        {
            ICharger crg = ChargerFactory.GetCharger(ChargerTypes.Powerbk);
            double actRes = crg.CalculateChargingTime(0);
            double expRes = 0;
            Assert.AreEqual(expRes, actRes);
        }
    }
}
