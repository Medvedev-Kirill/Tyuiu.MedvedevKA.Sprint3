using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint3.Task0.V1.Lib;

namespace Tyuiu.MedvedevKA.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double res = ds.GetSumSeries(x);
            double wait = 1935;

            Assert.AreEqual(res,wait);
        }
    }
}
