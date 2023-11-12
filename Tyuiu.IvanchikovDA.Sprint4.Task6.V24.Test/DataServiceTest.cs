using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            var data = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            int[] res = ds.Calculate(data);
            int waitdata = { "Компьютер", "Клавиатура" };
            CollectionAssert.AreEqual(waitdata, res);
        }
    }
}
