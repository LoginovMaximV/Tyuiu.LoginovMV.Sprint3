using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint3.Task5.V20.Lib;

namespace Tyuiu.LoginovMV.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Вложенные циклы                                                                                      *");
            Console.WriteLine("* Задание #5                                                                                                 *");
            Console.WriteLine("* Вариант #20                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Найти сумму ряда с помощью вложенного цикла, при х = 5                                                     *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;
            Console.WriteLine("Значение х:" + x);
            Console.WriteLine("Старт шага первого цикла:" + startValue1);
            Console.WriteLine("Старт шага второго цикла:" + startValue2);
            Console.WriteLine("Конец шага первого цикла:" + stopValue1);
            Console.WriteLine("Конец шага второго цикла:" + stopValue2);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Сумма ряда =" + res);
            Console.ReadKey();

        }
    }
}
