using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> commandChars = new List<char>()
                {
                    'c', 'o', 'n'
                };
            string newWord = string.Empty;
            string message = string.Empty;
            string command = Console.ReadLine();
            while (command != "End")
            {
                char ch = char.Parse(command);
                if (char.IsLetter(ch))
                {
                    if (commandChars.Contains(ch))
                    {
                        commandChars.Remove(ch);
                        if (commandChars.Count == 0)
                        {
                            message += " ";
                            newWord = message;
                            commandChars.Add('c');
                            commandChars.Add('o');
                            commandChars.Add('n');
                        }
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        message += ch;
                    }
                }
                command = Console.ReadLine();
            }

            //if (commandChars.Count != 0)
            //{
            //    int index = message.LastIndexOf(" ");
            //    if (index != -1)
            //    {
            //        message = message.Remove(index);
            //    }
            //}
            Console.WriteLine(newWord);
        }
    }
}
