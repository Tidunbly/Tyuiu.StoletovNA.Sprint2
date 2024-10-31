using Tyuiu.StoletovNA.Sprint2.Task6.V3.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Получение результата из switch                                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                            *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            DataService ds = new DataService();
            int value;
            Console.WriteLine("Введите номер дня:");
            value = Convert.ToInt32(Console.ReadLine());
            string res;

            if ((value < 1) || (value > 7))
            {
                res = "Неверный номер дня!";
            }
            else
            {
                res = $"Этот день - {ds.FindDayName(value)}";
            }

            Console.WriteLine("*Написать программу, которая использует сокращенную форму записи оператора*");
            Console.WriteLine("*а switch вычисляет требуемое значение и возвращает результат.            *");

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

            

            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}