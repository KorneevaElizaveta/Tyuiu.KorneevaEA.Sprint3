using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint3.Task2.V14.Lib;

namespace Tyuiu.KorneevaEA.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 125;

            Assert.AreEqual(wait, res);
        }
    }
}
