using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint4.Task7.V21.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            string str = "684259137159648";

            DataService ds = new DataService();
           
            Console.Title = "Спринт 4. Выполнил: Иванчиков Дмитрий Александрович | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                    *");
            Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту       *");
            Console.WriteLine("* Задание #7                                                   *");
            Console.WriteLine("* Вариант #21                                                  *");
            Console.WriteLine("* Выполнил: Иванчиков Д.А. | ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                     *");
            Console.WriteLine("Дана строка из одноразрядных цифр 684259137159648.             *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте               *");
            Console.WriteLine("* произведение четных чисел.                                   *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                             *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();

            int index = 0;

            Console.WriteLine("\n Массив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Произведение четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
