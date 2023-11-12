using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint4.Task7.V21.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "684259137159648";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 73728;
            Assert.AreEqual(wait, res);
        }
    }
}
