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
            double x = 0.25;
            double res = ds.GetMultiplySeries(x);
            double wait = 7.833;
          
            Assert.AreEqual(res,wait);
        }
    }
}
