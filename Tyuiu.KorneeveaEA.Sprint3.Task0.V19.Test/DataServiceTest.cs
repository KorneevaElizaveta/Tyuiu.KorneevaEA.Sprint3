using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneeveaEA.Sprint3.Task0.V19.Lib;

namespace Tyuiu.KorneeveaEA.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0.155;

            Assert.AreEqual(wait, res);
        }
    }
}
