using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] parsedInput = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                parsedInput[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < parsedInput.Length; i++)
            {
                Console.WriteLine($"{parsedInput[i]} => {Math.Round(parsedInput[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
