using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaslovDM.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                m++;

                if (m > 12)
                {
                    m = 1;
                    g++;
                }
            }

            return $"{n}.{m}.{g}";
        }
    }

   
}