using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint3.Task4.V12.Lib;

namespace Tyuiu.KorneevaEA.Sprint3.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Корнеева Е.А. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #4                                                               *");
            Console.WriteLine("*Вариант #12                                                              *");
            Console.WriteLine("*Выполнил: Корнеева Елизавета Андреевна | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая подсчитает значение функции на отрезке x     ");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int x = -5;
            int y = 5;



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x, y);

            Console.WriteLine("По моим подсчётам " + res);


            Console.ReadKey();
        }
    }
}
