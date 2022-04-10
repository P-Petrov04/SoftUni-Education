using System;

namespace ex._5_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyFoodKg = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int buyFoodGr = buyFoodKg * 1000;
            int allgramsNeeded = 0;

            while (input != "Adopted")
            {
                int grams = int.Parse(input);
                allgramsNeeded += grams;
                input = Console.ReadLine();  
            }

            if (allgramsNeeded > buyFoodGr)
            {
                double neededFood = allgramsNeeded - buyFoodGr;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
            else
            {
            int leftFood = buyFoodGr - allgramsNeeded;
            Console.WriteLine($"Food is enough! Leftovers: {leftFood} grams.");
            }
        }
    }
}
