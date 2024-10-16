using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StoletovNA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5 {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] rs = new bool[6];

            rs[0] = x == y; //False
            rs[1] = x != y; //True
            rs[2] = x < y; //True
            rs[3] = y > x; //True
            rs[4] = y <= x; //False
            rs[5] = y >= x; //True

            return rs;
        }
    }
}
