using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = operations[0];
            int s = operations[1];
            int x = operations[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            bool isContains = queue.Contains(x);
            if (isContains)
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNum = int.MaxValue;
                foreach (var num in queue)
                {
                    if (num < smallestNum)
                    {
                        smallestNum = num;
                    }
                }
                Console.WriteLine(smallestNum);
            }
        }
    }
}
