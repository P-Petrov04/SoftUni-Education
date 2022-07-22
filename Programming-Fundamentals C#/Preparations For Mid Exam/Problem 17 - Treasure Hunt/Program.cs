using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_17___Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] commands = input.Split();
                string typeCommand = commands[0];

                if (typeCommand == "Loot")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (items.Contains(commands[i]))
                        {
                            continue;
                        }
                        else
                        {
                            items.Insert(0, commands[i]);
                        }
                    }
                }
                else if (typeCommand == "Drop")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index >= items.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    string currentItem = "";

                    for (int i = index; i < items.Count; i++)
                    {
                        if (i == index)
                        {
                            currentItem = items[i];
                            break;
                        }
                    }

                    items.RemoveAt(index);
                    items.Add(currentItem);
                }
                else if (typeCommand == "Steal")
                {
                    int countOfStealedItems = int.Parse(commands[1]);
                    List<string> removedItems = new List<string>();
                    if (countOfStealedItems >= items.Count)
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            removedItems.Add(items[i]);
                        }
                        for (int i = 0; i < removedItems.Count; i++)
                        {
                            items.RemoveAt(0);
                        }
                    }
                    else
                    {
                        

                        for (int i = items.Count - countOfStealedItems; i <= items.Count - 1; i++)
                        {
                            removedItems.Add(items[i]);
                        }

                        for (int i = 1; i <= countOfStealedItems; i++)
                        {
                            items.RemoveAt(items.Count - 1);
                        }
                    }
                    Console.WriteLine(string.Join(", ", removedItems));
                }

                input = Console.ReadLine();
            }

            int allItemsLenght = 0;
            foreach (string item in items)
            {
                allItemsLenght += item.Length;
            }

            if (allItemsLenght > 0)
            {
                double average = (double)allItemsLenght / items.Count;
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
