using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9___Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = numbers.Sum();
            double averageValue = (double)sum / numbers.Count;
            numbers.RemoveAll(number => number <= averageValue);
            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            numbers.Sort((a, b) => b.CompareTo(a));

            if (numbers.Count > 5)
            {
                while (numbers.Count > 5)
                {
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
