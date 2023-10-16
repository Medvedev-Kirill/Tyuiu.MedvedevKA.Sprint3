using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint3.Task1.V8.Lib;

namespace Tyuiu.MedvedevKA.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 7.837;
          
            Assert.AreEqual(res,wait);
        }
    }
}
