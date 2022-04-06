using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int bujed = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersNum = int.Parse(Console.ReadLine());

            int priceForShip = 0;
            double discount = 0;
            double fishersDiscount = 0;

            if (season == "Spring")
            {
                priceForShip = 3000;
            }
            else if ( season == "Summer" || season == "Autumn")
            {
                priceForShip = 4200;
            }
            else if (season == "Winter")
            {
                priceForShip = 2600;
            }

            if (fishersNum <= 6)
            {
                discount = 0.1;
            }
            else if (fishersNum >= 7 && fishersNum <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }

            double price = priceForShip - priceForShip * discount;

            if (fishersNum % 2 == 0 && season != "Autumn")
            {
                fishersDiscount = 0.05;
            }

            double finalPrice = price - price * fishersDiscount;

            if(bujed >= finalPrice)
            {
                Console.WriteLine($"Yes! You have {bujed - finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice - bujed:f2} leva.");
            }
        }
    }
}
