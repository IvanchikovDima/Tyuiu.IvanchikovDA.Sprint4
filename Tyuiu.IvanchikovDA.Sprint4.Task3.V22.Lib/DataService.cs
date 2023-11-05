using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IvanchikovDA.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int max = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[0, i] > max)
                    max = array[0, i];
            }
            return max;
        }
    }
}
