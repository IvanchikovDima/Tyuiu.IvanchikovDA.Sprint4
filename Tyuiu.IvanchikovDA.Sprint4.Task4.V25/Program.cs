using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint4.Task4.V25.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task4.V25
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
            Console.WriteLine("* Задание #4                                                   *");
            Console.WriteLine("* Вариант #25                                                  *");
            Console.WriteLine("* Выполнил: Иванчиков Д.А. | ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                     *");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов,           *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 6.   *");
            Console.WriteLine("* Найдите сумму четных элементов массива.                      *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                             *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();


            Console.WriteLine("Введите колличество срок в массиве : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колличество столбцов в массиве : ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("****************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Массив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                   *");
            Console.WriteLine("****************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
