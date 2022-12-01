using System;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string commandInfo = Console.ReadLine();
            while (commandInfo != "Reveal")
            {
                string[] commandArgs = commandInfo.Split(":|:");

                string typeCommand = commandArgs[0];
                if (typeCommand == "InsertSpace")
                {
                    int indexToInsert = int.Parse(commandArgs[1]);

                    message = InsertSpace(message, indexToInsert);
                    Console.WriteLine(message);
                }
                else if (typeCommand == "Reverse")
                {
                    string substring = commandArgs[1];
                    if (message.Contains(substring))
                    {
                        message = ReversePartOfMessage(message, substring);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (typeCommand == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    message = ChangeAllOccurences(message, substring, replacement);
                    Console.WriteLine(message);
                }

                commandInfo = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        static string InsertSpace(string message, int indexToInsert)
        {
            message = message.Insert(indexToInsert, " ");
            return message;
        }
        static string ReversePartOfMessage(string message, string substring)
        {
            int indexOfSubst = message.IndexOf(substring);
            message = message.Remove(indexOfSubst, substring.Length);
            string subStrToAdd = string.Empty;
            for (int i = substring.Length - 1; i >= 0; i--)
            {
                subStrToAdd += substring[i];
            }
            message = message.Insert(message.Length, subStrToAdd);
            return message;
        }

        static string ChangeAllOccurences(string message, string subString, string replacement)
        {
            message = message.Replace(subString, replacement);
            return message;
        }
    }
}
