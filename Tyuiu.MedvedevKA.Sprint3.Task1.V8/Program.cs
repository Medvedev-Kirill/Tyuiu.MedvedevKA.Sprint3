using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint3.Task1.V8.Lib;

namespace Tyuiu.MedvedevKA.Sprint3.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                          *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                                              *");
            Console.WriteLine("* Задание #1                                                                                                         *");
            Console.WriteLine("* Вариант #8                                                                                                         *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда по формуле, при х=0,25                       *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double res = ds.GetMultiplySeries(x);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Сумма ряда: " + res);

            Console.ReadKey();
        }
    }
}
