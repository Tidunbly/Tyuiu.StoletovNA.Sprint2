using Tyuiu.StoletovNA.Sprint2.Task2.V14.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Оператор if – полная и короткая форма записи                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры и *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*и.                                                                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            Console.WriteLine("Введите значение переменной x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в закрашенной области");
            }

            Console.ReadKey();
        }
    }
}