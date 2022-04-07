using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if (number > max)
                {
                    max = number;
                }
            }

            int numWithOutMaxNumber = sum - max;

            if (max == numWithOutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = max - numWithOutMaxNumber;
                diff = Math.Abs(diff);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
