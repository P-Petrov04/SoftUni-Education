using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            List<string> listWithNames = new List<string>();
            for (int i = 1; i <= countOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split();
                string nameOfGuest = commands[0];
                
                if (commands[2] == "going!" && !(listWithNames.Contains(nameOfGuest)))
                {
                    listWithNames.Add(nameOfGuest);
                }
                else if (listWithNames.Contains(nameOfGuest) && commands[2] == "going!")
                {
                    Console.WriteLine($"{nameOfGuest} is already in the list!");
                }
                else if (commands[2] == "not" && listWithNames.Contains(nameOfGuest))
                {
                    listWithNames.Remove(nameOfGuest);
                }
                else if (commands[2] == "not" && !(listWithNames.Contains(nameOfGuest)))
                {
                    Console.WriteLine($"{nameOfGuest} is not in the list!");
                }
            }

            foreach (string name in listWithNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
