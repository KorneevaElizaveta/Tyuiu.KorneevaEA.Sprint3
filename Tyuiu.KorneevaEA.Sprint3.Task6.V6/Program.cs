using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KorneevaEA.Sprint3.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Корнеева Е.А. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("*Выполнил: Корнеева Елизавета Андреевна | АСОиУб-23-3                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [16, 24] количество всех делителей больше 10          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine(" Начало отрезка = " + startValue);
            Console.WriteLine(" Конец отрезка  = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($" Количество делителей > 10 = {ds.GetSumTheDivisors(startValue, stopValue) }");
            Console.ReadKey();
        }
    }
}
