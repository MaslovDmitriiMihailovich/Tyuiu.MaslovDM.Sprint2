using System;
using Tyuiu.MaslovDM.Sprint2.Task0.V15.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3105;
            int y = 275;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 3105, y = 275                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine(string.Join(", ", result));

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}