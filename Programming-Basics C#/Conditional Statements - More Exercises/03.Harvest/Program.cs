using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapes = X * Y;
            double wine = grapes * 0.4 / 2.5;

            if(wine >= Z)
            {
                double wineLeft = wine - Z;
                double wineForWorker = wineLeft / workers;

                Console.WriteLine($"Good harvest this year! Total wine: {wine = Math.Floor(wine)} liters.");
                Console.WriteLine($"{wineLeft = Math.Ceiling(wineLeft)} liters left -> {wineForWorker = Math.Ceiling(wineForWorker)} liters per person.");
            }
            else
            {
                double wineNeeded = Z - wine;
                Console.WriteLine($"It will be a tough winter! More {wineNeeded = Math.Floor(wineNeeded)} liters wine needed.");
            }
        }
    }
}
