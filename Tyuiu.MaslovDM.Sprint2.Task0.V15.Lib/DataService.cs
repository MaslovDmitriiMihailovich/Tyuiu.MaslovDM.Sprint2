namespace Tyuiu.MaslovDM.Sprint2.Task0.V15.Lib
{
    public class DataService
    {
        public bool[] GetMassCompare(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x - y == y * 10; 
            result[1] = x % y != 80;    
            result[2] = y * 2 < x;      
            result[3] = x - y > y * 10;
            result[4] = x + y <= x - y; 
            result[5] = y * 2 >= x - y; 

            return result;
        }
    }
}