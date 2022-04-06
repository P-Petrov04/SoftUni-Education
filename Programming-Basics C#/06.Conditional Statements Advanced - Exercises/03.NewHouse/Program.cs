using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int bujed = int.Parse(Console.ReadLine());

            double price = 0.00;
            
            if (typeFlower == "Roses")
            {
                price = numOfFlowers * 5.00;

                if(numOfFlowers > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (typeFlower == "Dahlias")
            {
                price = numOfFlowers * 3.80;

                if (numOfFlowers > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (typeFlower == "Tulips")
            {
                price = numOfFlowers * 2.80;

                if ( numOfFlowers > 80)
                {
                    price = price - price * 0.15;
                }
            }
            else if (typeFlower == "Narcissus")
            {
                price = numOfFlowers * 3.00;

                if (numOfFlowers < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else if (typeFlower == "Gladiolus")
            {
                price = numOfFlowers * 2.50;

                if (numOfFlowers < 80)
                {
                    price = price + price * 0.20;
                }
            }

            if (bujed > price)
            {
                double moneyLeft = bujed - price;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeFlower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = price - bujed;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
