using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, string> registeredCars = new Dictionary<string, string>();

            for (int i = 1; i <= numberOfComands; i++)
            {
                string[] command = Console.ReadLine().Split();

                string typeCommand = command[0];

                if (typeCommand == "register")
                {
                    string username = command[1];
                    string licensePlateNumber = command[2];

                    if (registeredCars.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        registeredCars.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else
                {
                    string username = command[1];

                    if (!registeredCars.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredCars.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in registeredCars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
