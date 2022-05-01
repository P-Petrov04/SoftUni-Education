using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> numbersOccurrences = new SortedDictionary<int, int>();

            //2 3 2 2 3
            foreach (int number in numbers)
            {
                if (numbersOccurrences.ContainsKey(number))
                {
                    numbersOccurrences[number] += 1;
                }
                else
                {
                    numbersOccurrences.Add(number, 1);
                }
            }

            foreach (var number in numbersOccurrences)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
