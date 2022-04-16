using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                long greater = numbers.OrderByDescending(x => x = x).First();
                long sum = 0;

                while (greater != 0)
                {
                    sum += Math.Abs(greater % 10);
                    greater /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
