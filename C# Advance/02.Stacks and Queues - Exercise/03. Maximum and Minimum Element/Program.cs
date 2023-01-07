using System;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string type = command[0];
                if (type == "1")
                {
                    int numToAdd = int.Parse(command[1]);
                    stack.Push(numToAdd);
                }
                else if (type == "2")
                {
                    stack.Pop();
                }
                else if (type == "3")
                {
                    if (stack.Count != 0)
                    {
                        int maxNum = int.MinValue;
                        foreach (var num in stack)
                        {
                            if (num > maxNum)
                            {
                                maxNum = num;
                            }
                        }
                        Console.WriteLine(maxNum);
                    }
                }
                else if (type == "4")
                {
                    if (stack.Count != 0)
                    {
                        int minNum = int.MaxValue;
                        foreach (var num in stack)
                        {
                            if (num < minNum)
                            {
                                minNum = num;
                            }
                        }
                        Console.WriteLine(minNum);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
