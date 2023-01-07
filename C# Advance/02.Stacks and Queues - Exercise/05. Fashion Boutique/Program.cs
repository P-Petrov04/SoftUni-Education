using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(values);
            int countOfRacks = 1;
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int currValue = stack.Peek();
                if (sum + currValue <= capacity)
                {
                    sum += currValue;
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        break;
                    }
                    if (sum == capacity && stack.Count != 0)
                    {
                        countOfRacks++;
                        sum = 0;
                    }
                }
                else
                {
                    i--;
                    countOfRacks++;
                    sum = 0;
                }
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
