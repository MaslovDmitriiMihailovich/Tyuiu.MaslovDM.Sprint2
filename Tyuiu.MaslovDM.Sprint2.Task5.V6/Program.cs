using System;
using Tyuiu.Sprint2.Task5.V6.Lib;

namespace Tyuiu.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите номер масти m (от 1 до 4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер достоинства карты k (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res = ds.GetCardName(m, k);
            Console.WriteLine($"Название карты: {res}");

            Console.ReadKey();
        }
    }
}