using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCities = int.Parse(Console.ReadLine());
            int counterForThirdCity = 0;
            int counterForFifthCity = 0;
            double totalProfit = 0;

            for (int i = 1; i <= countOfCities; i++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                counterForThirdCity++;
                counterForFifthCity++;
                if (counterForThirdCity == 3 && counterForFifthCity == 5)
                {
                    income -= income * 0.1;
                    counterForFifthCity = 0;
                }
                else if (counterForThirdCity == 3)
                {
                    expenses += expenses * 0.5;
                    counterForThirdCity = 0;
                }
                else if (counterForFifthCity == 5)
                {
                    income -= income * 0.1;
                    counterForFifthCity = 0;
                }

                double profit = income - expenses;
                totalProfit += profit;
                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
