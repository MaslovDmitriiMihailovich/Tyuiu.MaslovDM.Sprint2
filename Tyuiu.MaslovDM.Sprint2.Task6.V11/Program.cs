using System;
using Tyuiu.MaslovDM.Sprint2.Task6.V11.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 12;
            int n = 31;

            Console.WriteLine("g = " + g + ", m = " + m + ", n = " + n);
            Console.WriteLine("Следующий день: " + ds.FindDateOfNextDay(g, m, n));

            Console.ReadKey();
        }
    }
}