using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForVegetables = double.Parse(Console.ReadLine());
            double priceForFruits = double.Parse(Console.ReadLine());
            int countVegetable = int.Parse(Console.ReadLine());
            int countFruits = int.Parse(Console.ReadLine());

            double priceForAll = priceForVegetables * countVegetable + priceForFruits * countFruits;
            double priceInEuro = priceForAll / 1.94;
            Console.WriteLine($"{priceInEuro:f2}");
        }
    }
}
