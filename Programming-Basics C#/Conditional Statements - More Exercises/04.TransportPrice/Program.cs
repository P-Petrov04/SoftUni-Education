using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double moneyPerKm = 0;
            double moneyForTrip = 0;

            if (kilometers < 20)
            {
                if(timeOfDay == "day")
                {
                    moneyPerKm = 0.79;
                    moneyForTrip = 0.70 + kilometers * moneyPerKm;
                }
                else if (timeOfDay == "night")
                {
                    moneyPerKm = 0.9;
                    moneyForTrip = 0.7 + kilometers * moneyPerKm;
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                moneyPerKm = 0.09;
                moneyForTrip = kilometers * moneyPerKm;
            }
            else if (kilometers >= 100)
            {
                moneyPerKm = 0.06;
                moneyForTrip = kilometers * moneyPerKm;
            }
            Console.WriteLine($"{moneyForTrip:f2}");
        }
    }
}
