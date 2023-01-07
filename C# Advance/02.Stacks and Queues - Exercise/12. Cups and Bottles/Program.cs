using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(inputBottles);
            Queue<int> cups = new Queue<int>(inputCups);
            int wastedWater = 0;

            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currCup = cups.Peek();

                while (currCup > 0)
                {
                    int currBottle = bottles.Pop();
                    if (currCup > currBottle)
                    {
                        currCup -= currBottle;
                    }
                    else if (currCup <= currBottle)
                    {
                        cups.Dequeue();
                        wastedWater += currBottle - currCup;
                        break;
                    }
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
