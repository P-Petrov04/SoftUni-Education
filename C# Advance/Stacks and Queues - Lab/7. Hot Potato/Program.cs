using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> allNames = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            while (allNames.Count != 1)
            {
                string currChild = allNames.Dequeue();
                if (count != n)
                {
                    allNames.Enqueue(currChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currChild}");
                }
                if (count >= n)
                {
                    count = 0;
                }
                count++;
            }

            Console.WriteLine($"Last is {allNames.Peek()}");
        }
    }
}
