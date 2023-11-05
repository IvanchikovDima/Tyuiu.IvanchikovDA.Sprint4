using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint4.Task3.V22.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт 4. Выполнил: Иванчиков Дмитрий Александрович | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы                                      *");
            Console.WriteLine("* Задание #3                                                   *");
            Console.WriteLine("* Вариант #22                                                  *");
            Console.WriteLine("* Выполнил: Иванчиков Д.А. | ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                     *");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов,           *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 9.   *");
            Console.WriteLine("* Найдите максимальный элемент в первой строке массива.        *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                             *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            int[,] array = new int[5, 5] {       { 4, 4, 7, 8, 9 },
                                                 { 9, 5, 9, 7, 8 },
                                                 { 7, 4, 9, 4, 6 },
                                                 { 4, 4, 7, 4, 4 },
                                                 { 4, 5, 8, 6, 7 }  };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j] }\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                   *");
            Console.WriteLine("****************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент в первой строке = " + res);
            Console.ReadKey();

        }
    }
}
  

