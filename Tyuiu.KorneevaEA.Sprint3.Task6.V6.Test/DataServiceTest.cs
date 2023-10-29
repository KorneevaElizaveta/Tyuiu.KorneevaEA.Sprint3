using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint3.Task6.V6.Lib;


namespace Tyuiu.KorneevaEA.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            Assert.AreEqual(11, ds.GetSumTheDivisors(16, 24));
        }
    }
}
