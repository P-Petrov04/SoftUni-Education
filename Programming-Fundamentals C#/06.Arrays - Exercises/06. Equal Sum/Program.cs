using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int k = i; k < numbers.Length - 1; k++)
                {
                    rightSum += numbers[k + 1];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine($"{i}");
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
