using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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
            Stack<int> stack = new Stack<int>(numbers);
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            bool isContains = stack.Contains(x);
            if (isContains)
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNum = int.MaxValue;
                foreach (var num in stack)
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
