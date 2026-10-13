using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaslovDM.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int m, int k)
        {
            string rank = k switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => "Неизвестно"
            };

            string suit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => "неизвестно"
            };

            return $"{rank} {suit}";
        }
    }
}