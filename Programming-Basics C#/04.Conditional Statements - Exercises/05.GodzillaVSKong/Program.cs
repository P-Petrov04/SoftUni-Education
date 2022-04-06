using System;

namespace _05.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmMoney = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForOneOutFit = double.Parse(Console.ReadLine());

            double priceForDecorations = filmMoney * 0.1;
            double priceForAllOutFit = statists * priceForOneOutFit;
            if(statists > 150)
            {
                priceForAllOutFit = priceForAllOutFit - (priceForAllOutFit * 0.1);
            }
            double finalPriceForFilm = priceForDecorations + priceForAllOutFit;
            if (finalPriceForFilm > filmMoney)
            {
                double moneyNeeded = finalPriceForFilm - filmMoney;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else
            {
                double moneyLeft = filmMoney - finalPriceForFilm;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
