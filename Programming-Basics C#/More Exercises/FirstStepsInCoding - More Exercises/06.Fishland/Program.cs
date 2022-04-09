using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerel = double.Parse(Console.ReadLine());
            double toy = double.Parse(Console.ReadLine());
            double countBonito = double.Parse(Console.ReadLine());
            double countThorseMackerel = double.Parse(Console.ReadLine());
            int countMussels = int.Parse(Console.ReadLine());

            double priceForBonito = mackerel + mackerel * 0.60;
            double priceForThorseMackerel = toy + toy * 0.80;

            double finalPriceForBonito = countBonito * priceForBonito;
            double finalPriceForThorseMackerel = countThorseMackerel * priceForThorseMackerel;
            double priceForMussels = countMussels * 7.50;

            double finalPrice = finalPriceForBonito + finalPriceForThorseMackerel + priceForMussels;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
