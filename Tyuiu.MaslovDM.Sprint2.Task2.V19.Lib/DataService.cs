using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaslovDM.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((x >= 2 && x <= 4 && y >= 3 && y <= 6) ||
                (x >= 9 && x <= 11 && y >= 3 && y <= 4) ||
                (x >= 5 && x <= 13 && y >= 5 && y <= 6) ||
                (x >= 9 && x <= 11 && y >= 5 && y <= 10) ||
                (x >= 6 && x <= 7 && y >= 7 && y <= 10) ||
                (x >= 2 && x <= 3 && y >= 10 && y <= 10) ||
                (x >= 6 && x <= 8 && y >= 12 && y <= 13) ||
                (x >= 8 && x <= 13 && y >= 11 && y <= 14))
            {
                res = true;
            }

            return res;
        }
    }
}