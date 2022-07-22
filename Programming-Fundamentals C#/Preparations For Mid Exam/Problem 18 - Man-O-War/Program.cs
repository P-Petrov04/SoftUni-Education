using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_18___Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> statusOfPirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> statusOfWarship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Retire")
            {
                string[] commands = input.Split();
                string typeOfCommand = commands[0];

                if (typeOfCommand == "Fire")
                {
                    int index = int.Parse(commands[1]);
                    int damage = int.Parse(commands[2]);

                    if (index < 0 || index >= statusOfWarship.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        statusOfWarship[index] -= damage;
                        if (statusOfWarship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (typeOfCommand == "Defend")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int damage = int.Parse(commands[3]);

                    if (startIndex < 0 || startIndex >= statusOfPirateShip.Count || endIndex < 0 || endIndex >= statusOfPirateShip.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            statusOfPirateShip[i] -= damage;
                            if (statusOfPirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (typeOfCommand == "Repair")
                {
                    int index = int.Parse(commands[1]);
                    int health = int.Parse(commands[2]);
                    if (index < 0 || index >= statusOfPirateShip.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        statusOfPirateShip[index] += health;
                        if (statusOfPirateShip[index] > maxHealth)
                        {
                            statusOfPirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (typeOfCommand == "Status")
                {
                    int counter = 0;
                    for (int i = 0; i < statusOfPirateShip.Count; i++)
                    {
                        if (statusOfPirateShip[i] < maxHealth * 0.2)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }

                input = Console.ReadLine();
            }

            int pirateShipSum = statusOfPirateShip.Sum();
            int warshipSum = statusOfWarship.Sum();

            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warshipSum}");
        }
    }
}
