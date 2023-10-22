using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint3.Task3.V22.Lib;

namespace Tyuiu.KorneevaEA.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string value = "tbtbbb dsfbg bbg";
            char item = 'b';

            int res = ds.GetMaxCharCount(value, item);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
