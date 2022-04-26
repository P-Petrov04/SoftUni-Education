using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> originalDrums = new List<int>();
            foreach (int drum in drums)
            {
                originalDrums.Add(drum);
            }

            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i] <= 0)
                    {
                        if (money - originalDrums[i] * 3 <= 0)
                        {
                            drums.RemoveAt(i);
                            originalDrums.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            money -= originalDrums[i] * 3;
                            drums[i] = originalDrums[i];
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
