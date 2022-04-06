using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMagnolias = int.Parse(Console.ReadLine());
            int countHyacinths = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine());
            int countCacti = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double priceForAllFlowers = countMagnolias * 3.25 + countHyacinths * 4 + countRoses * 3.50 + countCacti * 8;
            double finalPrice = priceForAllFlowers - priceForAllFlowers * 0.05;

            if (finalPrice >= giftPrice)
            {
                double moneyLeft = finalPrice - giftPrice;
                moneyLeft = Math.Floor(moneyLeft);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double moneyNeed = giftPrice - finalPrice;
                moneyNeed = Math.Ceiling(moneyNeed);
                Console.WriteLine($"She will have to borrow {moneyNeed} leva.");
            }
        }
    }
}
