using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint3.Task3.V23.Lib;

namespace Tyuiu.MedvedevKA.Sprint3.Task3.V23
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
            Console.WriteLine("* Тема: Оператор цикла foreach                                                                                       *");
            Console.WriteLine("* Задание #3                                                                                                         *");
            Console.WriteLine("* Вариант #23                                                                                                        *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Используя цикл foreach заменить буквы s на цифру 8 в строке: fdsst siu vsrs                                        *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Заменяемый символ = " + replaceable);
            Console.WriteLine("Замена символа = " + replacement);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Измененная строка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));

            Console.ReadKey();
        }
    }
}
