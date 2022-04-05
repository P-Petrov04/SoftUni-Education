using System;

namespace _05.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPacketsOfChemicals = int.Parse(Console.ReadLine()); 
            int numberPacketsOfMarkers = int.Parse(Console.ReadLine());
            int litersPreparation = int.Parse(Console.ReadLine());
            int percents = int.Parse(Console.ReadLine());

            //Цена на пакетите химикали => 2 * 5.80 = 11.60 лв.
            double priceForChemicals = numberPacketsOfChemicals * 5.80;
            //Цена на пакетите маркери => 3 * 7.20 = 21.60 лв.
            double priceForMarkers = numberPacketsOfMarkers * 7.20;
            //Цена на препарата => 4 * 1.20 = 4.80 лв.
            double priceforPreparation = litersPreparation * 1.20;
            //Цена за всички материали => 11.60 + 21.60 + 4.80 = 38.00 лв.
            double fullPrice = priceForChemicals + priceForMarkers + priceforPreparation;
            //Цена с намаление = 38.00 – (38.00 * 0.25) = 28.50 лв.
            double discount = percents * 0.01;
            double finalPrice = fullPrice - (fullPrice * discount);

            Console.WriteLine(finalPrice);
        }
    }
}
