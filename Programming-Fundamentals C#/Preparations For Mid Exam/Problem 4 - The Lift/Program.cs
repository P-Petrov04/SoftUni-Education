using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacityOfOneWagon = 4;
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> peopleInWagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int fullWagons = 0;

            for (int i = 0; i < peopleInWagons.Count; i++)
            {
                if (peopleWaiting == 0)
                {
                    break;
                }
                while (peopleInWagons[i] < 4 && peopleWaiting > 0)
                {
                    peopleInWagons[i]++;
                    peopleWaiting--;
                }
                if (peopleInWagons[i] == 4)
                {
                fullWagons++;
                }
            }

            if (peopleWaiting == 0 && fullWagons == peopleInWagons.Count)
            {
                Console.WriteLine(string.Join(" ", peopleInWagons));
            }
            else if (peopleWaiting == 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", peopleInWagons));
            }
            else if (peopleWaiting > 0 && fullWagons == peopleInWagons.Count)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", peopleInWagons));
            }
        }
    }
}
