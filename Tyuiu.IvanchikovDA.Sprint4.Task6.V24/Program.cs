using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 4. Выполнил: Иванчиков Дмитрий Александрович | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)         *");
            Console.WriteLine("* Задание #5                                                   *");
            Console.WriteLine("* Вариант #26                                                  *");
            Console.WriteLine("* Выполнил: Иванчиков Д.А. | ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                     *");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов,           *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 4.    *");
            Console.WriteLine("* Заменить положительные элементы на 1." +
                "                     *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                             *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите колличество срок в массиве : ");
            var data = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            Console.WriteLine("Исходный массив :");
            for (int i = 0; i <= data.Length - 1; i++)
            {
                Console.WriteLine(data[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длинна которых меньше 7 : ");

            int nums = ds.Calculate(data);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
