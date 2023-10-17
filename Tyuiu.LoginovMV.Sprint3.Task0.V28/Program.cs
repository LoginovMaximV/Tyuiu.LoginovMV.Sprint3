using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint3.Task0.V28.Lib;

namespace Tyuiu.LoginovMV.Sprint3.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла for                                                                                   *");
            Console.WriteLine("* Задание #0                                                                                                 *");
            Console.WriteLine("* Вариант #28                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле,                     *");
            Console.WriteLine("* при X=0,25                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;
            Console.WriteLine("переменная Х:" + value);
            Console.WriteLine("старт шага:" + startValue);
            Console.WriteLine("конец шага:" + stopValue);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Произведение ряда =" + res);
            Console.ReadKey();
        }
    }
}
