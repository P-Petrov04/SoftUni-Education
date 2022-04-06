using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsBikers = int.Parse(Console.ReadLine());
            int seniorsBikers = int.Parse(Console.ReadLine());
            string typeRace = Console.ReadLine();

            double rentMoney = 0;
            double discount = 0;

            if (typeRace == "trail")
            {
                rentMoney = juniorsBikers * 5.5 + seniorsBikers * 7;
            }
            else if (typeRace == "cross-country")
            {
                if (juniorsBikers + seniorsBikers >= 50)
                {
                    discount = 0.25;
                }
                rentMoney = (8 - 8 * discount) * juniorsBikers + (9.5 - 9.5 * discount) * seniorsBikers;
            }
            else if (typeRace == "downhill")
            {
                rentMoney = juniorsBikers * 12.25 + seniorsBikers * 13.75;
            }
            else if (typeRace == "road")
            {
                rentMoney = juniorsBikers * 20 + seniorsBikers * 21.5;
            }

            double money = rentMoney - rentMoney * 0.05;

            Console.WriteLine($"{money:f2}");
        }
    }
}
