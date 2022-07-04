using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6___Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split();
                string typeOfCommand = commands[0];

                if (typeOfCommand == "Shoot")
                {
                    int index = int.Parse(commands[1]);
                    int power = int.Parse(commands[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (typeOfCommand == "Add")
                {
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (typeOfCommand == "Strike")
                {
                    int index = int.Parse(commands[1]);
                    int radius = int.Parse(commands[2]);
                    if (index >= 0 && index < targets.Count && index + radius < targets.Count && index - radius >= 0)
                    {
                        //if (index + radius == targets.Count - 1 && index - radius == 0)
                        //{
                        //    continue;
                        //}
                        targets.RemoveRange(index, radius + 1);
                        targets.RemoveRange(index - radius, radius);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
