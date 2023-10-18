using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint3.Task1.V28.Lib;

namespace Tyuiu.LoginovMV.Sprint3.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                                 *");
            Console.WriteLine("* Задание #1                                                                                                 *");
            Console.WriteLine("* Вариант #28                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда по формуле,                     *");
            Console.WriteLine("* при а=0,5                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;
            Console.WriteLine("переменная а:" + value);
            Console.WriteLine("старт шага:" + startValue);
            Console.WriteLine("конец шага:" + stopValue);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда =" + res);
            Console.ReadKey();
        }
    }
}
