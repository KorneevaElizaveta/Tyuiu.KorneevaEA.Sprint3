﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint3.Task2.V14.Lib;

namespace Tyuiu.KorneevaEA.Sprint3.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 6;

            Console.Title = "Спринт #3 | Выполнила: Корнеева Е.А. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while.                                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Корнеева Елизавета Андреевна | АСОиУб-23-3                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при x = 5.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine(" Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Произведение ряда  = " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
