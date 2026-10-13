using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaslovDM.Sprint2.Task4.V23.Lib
{
    public class DataService : ISprint2Task4V23
    {
        public double Calculate(double x, double y)
        {
            double z = (x + 2 < Math.Sqrt(y) + 3)
                ? Math.Pow(1.0 + (1.0 / Math.Pow(y, 2)), x)
                : y + 12.0 * x - (1.0 / x);

            return Math.Round(z, 3);

        }
    }
}