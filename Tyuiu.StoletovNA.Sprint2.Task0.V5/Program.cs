using Tyuiu.StoletovNA.Sprint2.Task0.V5.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task0.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу из операций сравнений и арифметических выражений, кото*");
            Console.WriteLine("*орая вернет логическую последовательность.                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x, y;
            x = 105;
            y = 223;
            bool[] result = new bool[6];

            result = ds.GetCompareOperations(x, y);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(result[i]);
            }
            
            Console.ReadKey();
        }
    }
}