using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint4.Task2.V26.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 6, 7, 5, 3, 7, 5, 8, 4, 2, 5, 8, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 91875;
            Assert.AreEqual(wait, res);
        }
    }
}
