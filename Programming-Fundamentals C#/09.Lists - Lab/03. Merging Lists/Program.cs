using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int longerList = Math.Max(numbers1.Count, numbers2.Count);

            for (int i = 0; i < longerList; i++)
            {
                if (i < numbers1.Count)
                {
                    result.Add(numbers1[i]);
                }

                if (i < numbers2.Count)
                {
                    result.Add(numbers2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
