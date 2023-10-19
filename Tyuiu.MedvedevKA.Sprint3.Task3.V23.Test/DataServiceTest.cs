using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint3.Task3.V23.Lib;

namespace Tyuiu.MedvedevKA.Sprint3.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string str = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';

            string res = ds.ReplaceCharOnNum(str, replaceable, replacement);

            string wait = "fd88t 8iu v8r8";

            Assert.AreEqual(wait, res);

        }
    }
}
