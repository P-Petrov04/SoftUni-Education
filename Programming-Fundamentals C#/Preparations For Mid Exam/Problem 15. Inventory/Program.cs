using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_15._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> materials = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] commands = input.Split(" - ");
                string typeCommand = commands[0];

                if (typeCommand == "Collect")
                {
                    string item = commands[1];
                    if (materials.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        materials.Add(item);
                    }
                }
                else if (typeCommand == "Drop")
                {
                    string item = commands[1];
                    if (materials.Contains(item))
                    {
                        materials.Remove(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (typeCommand == "Combine Items")
                {
                    string[] items = commands[1].Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];
                    if (materials.Contains(oldItem))
                    {
                        int oldItemIndex = -1;
                        for (int i = 0; i < materials.Count; i++)
                        {
                            if (materials[i] == oldItem)
                            {
                                oldItemIndex = i;
                                break;
                            }
                        }
                        if (oldItemIndex + 1 < materials.Count)
                        {
                            materials.Insert(oldItemIndex + 1, newItem);
                        }
                        else
                        {
                            materials.Add(newItem);
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (typeCommand == "Renew")
                {
                    string item = commands[1];
                    if (materials.Contains(item))
                    {
                        materials.Remove(item);
                        materials.Add(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", materials));
        }
    }
}
