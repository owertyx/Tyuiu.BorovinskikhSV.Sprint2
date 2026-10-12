using Tyuiu.BorovinskikhSV.Sprint2.Task6.V9.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task6.V9
{
    class Program
    { 
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата дня характеризуется числами: m (номер месяца) и n (число).         *");
            Console.WriteLine("* По заданным n и m определить дату следующего дня                        *");
            Console.WriteLine("* (принять, что n и m не характеризуют 31 декабря).                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Следующий день: " + ds.FindDateOfNextDay(m, n));

            Console.ReadKey();
        }
    }
}   
