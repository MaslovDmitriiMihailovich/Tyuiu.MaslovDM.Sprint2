using System;
using Tyuiu.MaslovDM.Sprint2.Task7.V11.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка входит в заштрихованную область");
            }
            else
            {
                Console.WriteLine("Точка не входит в заштрихованную область");
            }

            Console.ReadKey();
        }
    }
}