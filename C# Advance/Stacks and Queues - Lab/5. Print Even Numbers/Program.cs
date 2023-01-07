using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Queue<int> evenNumbers = new Queue<int>(numbers.Where(n => n % 2 == 0));
            //Console.WriteLine(string.Join(", ", evenNumbers));
            Queue<int> evenNumbers = new Queue<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Enqueue(num);
                }
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
