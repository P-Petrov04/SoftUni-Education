using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "Finish")
            {
                string[] commands = input.Split();
                string typeCommand = commands[0];

                if (typeCommand == "Add")
                {
                    int newValue = int.Parse(commands[1]);
                    numbers.Add(newValue);
                }
                else if (typeCommand == "Remove")
                {
                    int newValue = int.Parse(commands[1]);
                    if (numbers.Contains(newValue))
                    {
                        numbers.Remove(newValue);
                    }
                }
                else if (typeCommand == "Replace")
                {
                    int value = int.Parse(commands[1]);
                    int newValue = int.Parse(commands[2]);
                    int oldValueIndex = -1;
                    if (numbers.Contains(value))
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == value)
                            {
                                oldValueIndex = i;
                                break;
                            }
                        }
                        numbers.RemoveAt(oldValueIndex);
                        numbers.Insert(oldValueIndex, newValue);
                    }
                }
                else if (typeCommand == "Collapse")
                {
                    int value = int.Parse(commands[1]);
                    numbers.RemoveAll(x => x < value);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
