using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int moneyPerYear = 0;
            int years = 18;

            for (int year = 1800; year <= yearToLive; year++)
            {
                
                if (year % 2 == 0)
                {
                    moneyPerYear += 12000;
                }
                else
                {
                    moneyPerYear += 12000 + 50 * years;
                }
                years++;
            }
            if (money >= moneyPerYear)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(money - moneyPerYear):f2} dollars left.");
            } 
            else
            {
                Console.WriteLine($"He will need {(moneyPerYear - money):f2} dollars to survive.");
            }
        }
    }
}
