using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string decriptedMessage = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string typeCommand = commandArgs[0];
                if (typeCommand == "Move")
                {
                    int numberOfLetters = int.Parse(commandArgs[1]);

                    string subStr = decriptedMessage.Substring(0, numberOfLetters);
                    decriptedMessage = decriptedMessage.Remove(0, numberOfLetters);
                    decriptedMessage += subStr;
                }
                else if (typeCommand == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    decriptedMessage = decriptedMessage.Insert(index, value);
                }
                else if (typeCommand == "ChangeAll")
                {
                    string subStr = commandArgs[1];
                    string replacement = commandArgs[2];

                    decriptedMessage = decriptedMessage.Replace(subStr, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {decriptedMessage}");
        }
    }
}
