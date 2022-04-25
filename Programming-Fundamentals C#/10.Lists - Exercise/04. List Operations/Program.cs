using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split();
                string typeCommand = commands[0];

                if (typeCommand == "Add")
                {
                    int numToAdd = int.Parse(commands[1]);
                    numbers.Add(numToAdd);
                }
                else if (typeCommand == "Insert")
                {
                    int numToInsert = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, numToInsert);
                    }
                }
                else if (typeCommand == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (typeCommand == "Shift")
                {
                    string direction = commands[1];
                    int count = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int numOfOldIndex = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(numOfOldIndex);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int numOfOldIndex = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, numOfOldIndex);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
