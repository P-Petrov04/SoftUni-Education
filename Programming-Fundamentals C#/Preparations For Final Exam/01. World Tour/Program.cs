using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] commandArgs = command.Split(":");

                string typeCommand = commandArgs[0];
                if (typeCommand == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string newStop = commandArgs[2];
                    if (IsIndexValid(index, stops))
                    {
                        stops = stops.Insert(index, newStop);
                    }
                    Console.WriteLine(stops);
                }
                else if (typeCommand == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    if (IsIndexValid(startIndex, stops) && IsIndexValid(endIndex, stops))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (typeCommand == "Switch")
                {
                    string oldStr = commandArgs[1];
                    string newStr = commandArgs[2];
                    if (stops.Contains(oldStr))
                    {
                        stops = stops.Replace(oldStr, newStr);
                    }
                    Console.WriteLine(stops);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        static bool IsIndexValid(int index, string stops)
        {
            if(index < 0 || index >= stops.Length)
            {
                return false;
            }
            return true;
        }
    }
}
