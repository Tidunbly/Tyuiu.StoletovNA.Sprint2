﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StoletovNA.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13 {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= x - 1) && (y <= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
