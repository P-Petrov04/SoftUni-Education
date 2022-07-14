using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_14._Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|").ToList();

            int myHealth = 100;
            int bitCoins = 0;
            int roomsCount = 0;
            for (int i = 0; i < rooms.Count; i++)
            {
                string currentRoom = rooms[i];
                string[] command = currentRoom.Split();
                string typeCommand = command[0];
                roomsCount++;

                if (typeCommand == "potion")
                {
                    int healthReceive = int.Parse(command[1]);
                    if (myHealth + healthReceive >= 100)
                    {
                        healthReceive = 100 - myHealth;
                        myHealth = 100;
                    }
                    else
                    {
                        myHealth += healthReceive;
                    }

                    Console.WriteLine($"You healed for {healthReceive} hp.");
                    Console.WriteLine($"Current health: {myHealth} hp.");
                }
                else if (typeCommand == "chest")
                {
                    int amountOfBitcoins = int.Parse(command[1]);
                    bitCoins += amountOfBitcoins;
                    Console.WriteLine($"You found {amountOfBitcoins} bitcoins.");
                }
                else
                {
                    int monsterPower = int.Parse(command[1]);
                    myHealth -= monsterPower;
                    if (myHealth > 0)
                    {
                        Console.WriteLine($"You slayed {typeCommand}.");
                    }
                    else
                    {
                        
                        Console.WriteLine($"You died! Killed by {typeCommand}.");
                        Console.WriteLine($"Best room: {roomsCount}");
                        break;
                    }
                }
            }

            if (myHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitCoins}");
                Console.WriteLine($"Health: {myHealth}");
            }
        }
    }
}
