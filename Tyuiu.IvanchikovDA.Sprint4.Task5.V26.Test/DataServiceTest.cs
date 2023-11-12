using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint4.Task5.V26.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] numsmas2 = new int[5, 5] {   { -2, 2, -1, -4, -4 },
                                            { -2, 4, -3, -3, 2 },
                                            { 4, 2, -1, -3, 2 },
                                            { -1, -2, -4, 4, -3 },
                                            { -2, 1, -3, 1, -2 }  };

            int[,] res = ds.Calculate(numsmas2);
            int[,] numswaitmus2 ={   { -2, 1, -1, -4, -4 },
                                     { -2, 1, -3, -3, 1 },
                                     { 1, 1, -1, -3, 1 },
                                     { -1, -2, -4, 1, -3 },
                                     { -2, 1, -3, 1, -2 }  }; 

            CollectionAssert.AreEqual(numswaitmus2, res);
        }
    }
}
