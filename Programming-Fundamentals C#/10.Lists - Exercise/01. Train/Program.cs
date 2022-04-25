using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> countOfPassengersInVagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] commands = input.Split();
                if (commands[0] == "Add")
                {
                    int passengersToAdd = int.Parse(commands[1]);
                    countOfPassengersInVagons.Add(passengersToAdd);
                }
                else
                {
                    int passengersToAddInCurrentVagon = int.Parse(commands[0]);

                    for (int i = 0; i < countOfPassengersInVagons.Count; i++)
                    {
                        if (countOfPassengersInVagons[i] + passengersToAddInCurrentVagon <= maxCapacity)
                        {
                            countOfPassengersInVagons[i] += passengersToAddInCurrentVagon;
                            i = -1;
                            break;
                        }
                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", countOfPassengersInVagons));
        }
    }
}
