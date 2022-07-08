using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11___Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] commands = input.Split();
                string typeCommand = commands[0];

                if (typeCommand == "Urgent")
                {
                    string item = commands[1];
                    if (groceries.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (typeCommand == "Unnecessary")
                {
                    string item = commands[1];
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (typeCommand == "Correct")
                {
                    string oldItem = commands[1];
                    string newItem = commands[2];
                    if (groceries.Contains(oldItem))
                    {
                        int indexOfOldItem = -1;
                        for (int i = 0; i < groceries.Count; i++)
                        {
                            if (groceries[i] == oldItem)
                            {
                                indexOfOldItem = i;
                            }
                        }
                        groceries.Remove(oldItem);
                        groceries.Insert(indexOfOldItem, newItem);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (typeCommand == "Rearrange")
                {
                    string item = commands[1];
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }        
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
