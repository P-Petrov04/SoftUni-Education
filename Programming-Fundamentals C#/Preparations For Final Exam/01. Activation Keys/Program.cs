using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string commandInfo = Console.ReadLine();
            while (commandInfo != "Generate")
            {
                string[] commandArgs = commandInfo.Split(">>>");

                string typeCommand = commandArgs[0];
                if (typeCommand == "Contains")
                {
                    string subStr = commandArgs[1];

                    if (rawActivationKey.Contains(subStr))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {subStr}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (typeCommand == "Flip")
                {
                    string caseType = commandArgs[1];
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);
                    string subStr = rawActivationKey.Substring(startIndex, endIndex - startIndex);
                    int indexOfSubStr = rawActivationKey.IndexOf(subStr);
                    rawActivationKey = rawActivationKey.Remove(indexOfSubStr, subStr.Length);
                    if (caseType == "Upper")
                    {
                        subStr = subStr.ToUpper();
                    }
                    else if (caseType == "Lower")
                    {
                        subStr = subStr.ToLower();
                    }
                    rawActivationKey = rawActivationKey.Insert(indexOfSubStr, subStr);
                    Console.WriteLine(rawActivationKey);
                }
                else if (typeCommand == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivationKey);
                }

                commandInfo = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
