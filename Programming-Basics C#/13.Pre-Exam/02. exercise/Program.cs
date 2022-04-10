using System;

namespace _02._exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyTereza = double.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double moneySpended = double.Parse(Console.ReadLine());
            double moneyGift = double.Parse(Console.ReadLine());

            double moneyTerezaForAllDays = moneyTereza * 5;
            double moneyForAllDaysBySelling = moneyPerDay * 5;
            double moneyHave = moneyForAllDaysBySelling + moneyTerezaForAllDays;
            double totalMoney = moneyHave - moneySpended;

            if (totalMoney >= moneyGift)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(moneyGift - totalMoney):f2} BGN.");
            }
        }
    }
}
