using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double moneyPerKm = 0;

            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    moneyPerKm = 0.75;
                }
                else if (season == "Summer")
                {
                    moneyPerKm = 0.90;
                }
                else if (season == "Winter")
                {
                    moneyPerKm = 1.05;
                }
            }
            else if (km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    moneyPerKm = 0.95;
                }
                else if (season == "Summer")
                {
                    moneyPerKm = 1.10;
                }
                else if (season == "Winter")
                {
                    moneyPerKm = 1.25;
                }
            }
            else if (km <= 20000)
            {
                moneyPerKm = 1.45;
            }

            double money = km * moneyPerKm;
            money = money * 4;
            money = money - money * 0.1;

            Console.WriteLine($"{money:f2}");
        }
    }
}
