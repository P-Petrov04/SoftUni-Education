using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujed = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());

            double transport = 0;
            double ticket = 0;

            if (fans >= 1 && fans <= 4)
            {
                transport = 0.75;
            }
            else if (fans >= 5 && fans <= 9)
            {
                transport = 0.6;
            }
            else if (fans >= 10 && fans <= 24)
            {
                transport = 0.5;
            }
            else if (fans >= 25 && fans <= 49)
            {
                transport = 0.4;
            }
            else if (fans >= 50)
            {
                transport = 0.25;
            }

            double moneyForTickets = bujed - bujed * transport;

            if (category == "VIP")
            {
                ticket = 499.99;
            }
            else if (category == "Normal")
            {
                ticket = 249.99;
            }

            double moneyForAllTickets = ticket * fans;

            if (moneyForTickets >= moneyForAllTickets)
            {
                double moneyLeft = moneyForTickets - moneyForAllTickets;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = moneyForAllTickets - moneyForTickets;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
