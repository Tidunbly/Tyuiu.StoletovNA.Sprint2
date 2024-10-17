using System.Runtime.Intrinsics.X86;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StoletovNA.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16 {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > -20)
            {
                
                if (x < 2)
                {
                    if (x == 0)
                    {
                        double n1, n2;
                        n1 = 2 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                        n2 = 5 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                        y = n1 / n2;
                    }
                    else {
                        double n1;
                        n1 = 1 + 1 / Math.Pow(x, 2);
                        y = Math.Pow(n1, 7);
                    }
                }
                else if (x > 1)
                {
                    double n1, n2;
                    n1 = x + 1;
                    n2 = x - 1;
                    y = x + Math.Pow(n1 / n2, 3);
                }

            }
            else if (x < -20)
            {
                y = x + 10 * x - 1 / x;
            }
            return Math.Round(y, 3);
        }
    }
}
