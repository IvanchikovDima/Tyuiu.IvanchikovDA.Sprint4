using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IvanchikovDA.Sprint4.Task0.V20.Lib
{
    public class DataService : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int num = 1;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if(array[i] % 2 == 0)
                {
                    num *= array[i];
                }
            }
            return num;

        }
    }
}
