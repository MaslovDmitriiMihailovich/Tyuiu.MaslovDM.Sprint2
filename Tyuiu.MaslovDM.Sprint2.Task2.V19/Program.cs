using Tyuiu.MaslovDM.Sprint2.Task2.V19.Lib;

DataService ds = new DataService();

Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);

if (res)
{
    Console.WriteLine("Точка находится в закрашенной области");
}
else
{
    Console.WriteLine("Точка не находится в закрашенной области");
}

Console.ReadKey();