using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            List<int> leftNums = new List<int>();
            int lessNum = -1;
            int biggerNum = -1;

            int lenghtMin = -1;
            if (first.Count < second.Count)
            {
                lenghtMin = first.Count;
                leftNums.Add(second[0]);
                leftNums.Add(second[1]);
                leftNums.Sort();
                lessNum = leftNums[0];
                biggerNum = leftNums[1];
            }
            else
            {
                lenghtMin = second.Count;
                leftNums.Add(first[first.Count - 1]);
                leftNums.Add(first[first.Count - 2]);
                leftNums.Sort();
                lessNum = leftNums[0];
                biggerNum = leftNums[1];
            }

            for (int i = 0; i < lenghtMin; i++)
            {
                result.Add(first[i]);
                result.Add(second[second.Count - 1 - i]);
            }

            List<int> numsToPrint = result.Where(n => n > lessNum && n < biggerNum).ToList();
            numsToPrint.Sort();
            Console.WriteLine(string.Join(" ", numsToPrint));
        }
    }
}
