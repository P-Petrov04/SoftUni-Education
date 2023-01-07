using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> myNumbers = new Stack<int>();
            foreach (int num in numbers)
            {
                myNumbers.Push(num);
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] commandArgs = command.Split();

                string typeCommand = commandArgs[0];
                if (typeCommand == "add")
                {
                    int num1 = int.Parse(commandArgs[1]);
                    int num2 = int.Parse(commandArgs[2]);

                    myNumbers.Push(num1);
                    myNumbers.Push(num2);
                }
                else if (typeCommand == "remove")
                {
                    int numsToRemove = int.Parse(commandArgs[1]);
                    if (numsToRemove <= myNumbers.Count)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            myNumbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            int sum = 0;
            //myNumbers.Sum();
            foreach (var num in myNumbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
