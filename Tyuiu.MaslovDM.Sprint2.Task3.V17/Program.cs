using Tyuiu.MaslovDM.Sprint2.Task3.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x);

        Console.WriteLine($"Y = {res}");
        Console.ReadKey();
    }
}