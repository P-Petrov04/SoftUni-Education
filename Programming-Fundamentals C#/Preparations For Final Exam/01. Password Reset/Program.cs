using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            List<char> charsInPassword = new List<char>();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string typeCommand = commandArgs[0];
                if (typeCommand == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        int index = i;
                        if (index % 2 != 0)
                        {
                            charsInPassword.Add(password[i]);
                        }
                    }
                    password = string.Join("", charsInPassword);
                    Console.WriteLine(password);
                }
                else if (typeCommand == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);

                    string subStr = password.Substring(index, length);
                    int indexOfSubStr = password.IndexOf(subStr);
                    password = password.Remove(indexOfSubStr, subStr.Length);
                    Console.WriteLine(password);
                }
                else if (typeCommand == "Substitute")
                {
                    string subString = commandArgs[1];
                    string subStitute = commandArgs[2];

                    if (password.Contains(subString))
                    {
                        password = password.Replace(subString, subStitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
