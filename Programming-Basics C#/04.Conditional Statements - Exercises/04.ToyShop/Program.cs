using System;

namespace _04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForVacation = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            double priceForToys = numPuzzles * 2.60 + numDolls * 3.00 + numBears * 4.10 + numMinions * 8.20 + numTrucks * 2.00;
            double numOfToys = numPuzzles + numDolls + numBears + numMinions + numTrucks;
            
            if(numOfToys >= 50)
            {
                priceForToys = priceForToys - (priceForToys * 0.25);
            }
            double priceForRentle = priceForToys * 0.1;
            double finalPrice = priceForToys - priceForRentle;

            if(finalPrice >= priceForVacation)
            {
                double moneyLeft = finalPrice - priceForVacation;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeed = priceForVacation - finalPrice;
                Console.WriteLine($"Not enough money! {moneyNeed:f2} lv needed.");
            }
        }
    }
}
