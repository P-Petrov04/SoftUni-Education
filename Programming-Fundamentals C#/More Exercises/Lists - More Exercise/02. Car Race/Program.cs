using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine().Split().Select(int.Parse).ToList();
            double sumLeft = 0;
            double sumRight = 0;
            int finishIndex = times.Count / 2 + 1;

            for (int i = 1; i < finishIndex; i++)
            {
                int currentTime = times[i - 1];
                if (currentTime != 0)
                {
                    sumLeft += currentTime;
                }
                else
                {
                    sumLeft *= 0.8;
                }
            }
            for (int i = times.Count - 1; i >= finishIndex; i--)
            {
                int currentTime = times[i];
                if (currentTime != 0)
                {
                    sumRight += currentTime;
                }
                else
                {
                    sumRight *= 0.8;
                }
            }

            if (sumLeft < sumRight)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
        }
    }
}
