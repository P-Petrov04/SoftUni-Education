using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPups = int.Parse(Console.ReadLine());
            Queue<int[]> pupsInfo = new Queue<int[]>();
            for (int i = 0; i < countPups; i++)
            {
                int[] currPupInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pupsInfo.Enqueue(currPupInfo);
            }

            int counter = -1;
            while (true)
            {
                counter++;
                bool isThisRightPup = true;
                int allLitters = 0;

                foreach (var item in pupsInfo)
                {
                    int littersGive = item[0];
                    int distanceToNext = item[1];

                    allLitters += littersGive;

                    if (allLitters >= distanceToNext)
                    {
                        allLitters -= distanceToNext;
                        continue;
                    }
                    else
                    {
                        isThisRightPup = false;
                        int[] currPup = pupsInfo.Dequeue();
                        pupsInfo.Enqueue(currPup);
                        break;
                    }
                }
                if (isThisRightPup)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
