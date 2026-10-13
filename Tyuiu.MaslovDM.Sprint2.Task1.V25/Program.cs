using System;
using Tyuiu.MaslovDM.Sprint2.Task1.V25.Lib;

namespace Tyuiu.MaslovDM.Sprint2.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 247;
            int b = 155;
            int c = 325;
            int d = 857;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"res[{i}] = {res[i]}");
            }

            Console.ReadKey();
        }
    }
}