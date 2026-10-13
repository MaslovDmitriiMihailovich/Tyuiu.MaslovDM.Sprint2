using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaslovDM.Sprint2.Task3.V17.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = Math.Pow(x, 2) + Math.Pow((x + 1) / (x - 1), 8);
            }
            else
            {
                if (x == 0)
                {
                    y = (2.0 + x - 3.0 * x) / (x - 7.0);
                }
                else
                {
                    if ((x > -21) && (x < 2))
                    {
                        y = Math.Pow((1.0 + (1.0 / Math.Pow(x, 2))), 4);
                    }
                    else
                    {
                        if (x < -21)
                        {
                            y = x + 10.0 * x - (1.0 / x);
                        }
                        else
                        {
                            y = x;
                        }
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}