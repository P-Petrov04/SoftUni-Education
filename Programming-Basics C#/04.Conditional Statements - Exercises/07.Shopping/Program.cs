using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujedPetar = double.Parse(Console.ReadLine());
            int countN = int.Parse(Console.ReadLine());
            int countM = int.Parse(Console.ReadLine());
            int countP = int.Parse(Console.ReadLine());

            double priceForN = countN * 250;

            double priceForOneM = priceForN * 0.35;
            double priceForM = priceForOneM * countM;

            double priceForOneP = priceForN * 0.1;
            double priceForP = countP * priceForOneP;

            double finalPrice = priceForN + priceForM + priceForP;
            double discount = 0.00;
            if(countN > countM)
            {
                discount = finalPrice * 0.15;
            }

            double newFinalPrice = finalPrice - discount;

            if (bujedPetar >= newFinalPrice)
            {
                double moneyLeft = bujedPetar - newFinalPrice;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeed = newFinalPrice - bujedPetar;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva more!");
            }
        }
    }
}
