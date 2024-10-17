using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StoletovNA.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14 {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            res = false;

            if (((y == 4) || (y == 5)) && (x == 2)) {
                res = true;
            }
            if ((x >= 3) && (x <= 5) && (((y >= 3) && (y <= 7)) || (y == 11)))
            {
                res = true;
            }
            if ((x == 6) && (y >= 5) && (y <= 11))
            {
                res = true;
            }
            if ((x >=7) && (x <=8) && (y >= 5) && (y <= 12))
            {
                res = true;
            }
            if ((x == 9) && ((y == 5) || ((y >= 11) && (y <= 12))))
            {
                res = true;
            }
            if ((x == 10)  && (((y >= 2) && (y <= 5)) || ((y >= 11) && (y <= 12)))){
                res = true;
            }
            if ((x >= 11) && (x <= 12) && (((y >= 2) && (y <= 5)) || (y == 11)))
            {
                res = true;
            }
            if ((x == 13) && (((y >= 2) && (y <= 3)) || ((y >= 9) && (y <= 13))))
            {
                res = true;
            }

            return res;
        }
    }
}
