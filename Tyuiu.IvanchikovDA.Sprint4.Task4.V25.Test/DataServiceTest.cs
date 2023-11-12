﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint4.Task4.V25.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {   { 3, 2, 4, 4, 4 },
                                            { 2, 6, 6, 3, 2 },
                                            { 4, 2, 5, 5, 2 },
                                            { 5, 5, 6, 4, 3 },
                                            { 2, 6, 5, 6, 2 }  };

            int res = ds.Calculate(mas2);
            int wait = 64;

            Assert.AreEqual(wait, res);
        }
    }
}
