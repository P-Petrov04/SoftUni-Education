using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] commands = input.Split();
                string typeOfCommand = commands[0];
                if (typeOfCommand == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else
                {
                    int element = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
