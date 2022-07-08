using System;

namespace Problem_10___Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodKg = double.Parse(Console.ReadLine());
            double hayKg = double.Parse(Console.ReadLine());
            double coverKg = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            int hayCounter = 0;
            int coverCounter = 0;

            double foodInGrams = foodKg * 1000;
            double hayInGrams = hayKg * 1000;
            double coverInGrams = coverKg * 1000;
            double weightInGrams = weight * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= 300;
                if (foodInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                hayCounter++;
                coverCounter++;

                if (hayCounter == 2)
                {
                    hayInGrams -= foodInGrams * 0.05;
                    hayCounter = 0;
                }
                if (coverCounter == 3)
                {
                    coverInGrams -= weightInGrams / 3;
                    coverCounter = 0;
                }
                if (hayInGrams <= 0 || coverInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            foodKg = foodInGrams / 1000;
            hayKg = hayInGrams / 1000;
            coverKg = coverInGrams / 1000;
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
        }
    }
}
