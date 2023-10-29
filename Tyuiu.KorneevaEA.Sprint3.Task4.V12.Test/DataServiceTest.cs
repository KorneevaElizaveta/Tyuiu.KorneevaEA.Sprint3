using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint3.Task4.V12.Lib;

namespace Tyuiu.KorneevaEA.Sprint3.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-606.317, ds.Calculate(-5, 5));
        }

    }
}
