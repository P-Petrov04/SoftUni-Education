using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[countWagons];

            int allPassengers = 0;

            for (int i = 0; i <= passengers.Length - 1; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                allPassengers += passengers[i];
            }

            Console.WriteLine(string.Join(' ', passengers));
            Console.WriteLine(allPassengers);
        }
    }
}
