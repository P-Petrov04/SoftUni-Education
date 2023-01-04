using System;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Abracadabra")
            {
                string[] commandArgs = command.Split(" ");

                string commandType = commandArgs[0];
                if (commandType == "Abjuration")
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (commandType == "Necromancy")
                {
                    message = message.ToLower();
                    Console.WriteLine(message);
                }
                else if (commandType == "Illusion")
                {
                    int index = int.Parse(commandArgs[1]);
                    string letter = commandArgs[2];
                    if (index < 0 || index >= message.Length)
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    else
                    {
                        message = message.Remove(index, 1);
                        message = message.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }
                }
                else if (commandType == "Divination")
                {
                    string firstSub = commandArgs[1];
                    string secondSub = commandArgs[2];
                    if (message.Contains(firstSub))
                    {
                        while (message.Contains(firstSub))
                        {
                            message = message.Replace(firstSub, secondSub);
                        }
                            Console.WriteLine(message);
                    }
                }
                else if (commandType == "Alteration")
                {
                    string subStr = commandArgs[1];
                    if (message.Contains(subStr))
                    {
                        int index = message.IndexOf(subStr);
                        message = message.Remove(index, subStr.Length);
                        Console.WriteLine(message);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
