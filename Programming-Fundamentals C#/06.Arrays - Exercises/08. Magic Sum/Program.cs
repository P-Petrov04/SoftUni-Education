using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumToFind = int.Parse(Console.ReadLine());

            int[] numForSum = new int[2];
            int currentSum = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    currentSum = 0;
                    currentSum = numbers[i] + numbers[j + 1];
                    if (currentSum == sumToFind)
                    {
                        numForSum[0] = numbers[i];
                        numForSum[1] = numbers[j + 1];
                        Console.Write(string.Join(" ", numForSum));
                        Console.WriteLine();
                        break;
                    }
                }
            }

        }
    }
}
