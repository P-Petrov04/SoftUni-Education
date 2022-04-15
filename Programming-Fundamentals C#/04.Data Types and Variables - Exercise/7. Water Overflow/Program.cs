using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesFollow = int.Parse(Console.ReadLine());

            int sumWater = 0;

            for (int i = 1; i <= linesFollow; i++)
            {
                int water = int.Parse(Console.ReadLine());
                if (sumWater + water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                sumWater += water;
            }

            Console.WriteLine(sumWater);
        }
    }
}
