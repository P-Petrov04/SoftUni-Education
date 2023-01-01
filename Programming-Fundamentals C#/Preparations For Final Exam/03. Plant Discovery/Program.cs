using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPlants = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRatings = new Dictionary<string, List<double>>();

            for (int i = 0; i < countOfPlants; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");

                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);
                if (plantRarity.ContainsKey(plantName))
                {
                    plantRarity[plantName] = rarity;
                }
                else
                {
                    plantRarity.Add(plantName, rarity);
                    plantRatings.Add(plantName, new List<double>());
                }
            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] commandArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string typeCommand = commandArgs[0];
                if (typeCommand == "Rate")
                {
                    string[] plantRatingInfo = commandArgs[1]
                        .Split(" - ",StringSplitOptions.RemoveEmptyEntries);

                    string plantName = plantRatingInfo[0];
                    int rating = int.Parse(plantRatingInfo[1]);

                    if (plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (typeCommand == "Update")
                {
                    string[] plantUpdate = commandArgs[1]
                        .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                    string plantName = plantUpdate[0];
                    int newRarity = int.Parse(plantUpdate[1]);
                    if (plantRarity.ContainsKey(plantName))
                    {
                        plantRarity[plantName] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (typeCommand == "Reset")
                {
                    string plantName = commandArgs[1];
                    if (plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantRatings)
            {
                string plantName = plant.Key;
                int currentRarity = plantRarity[plantName];
                double averageRating = 0;
                if (plant.Value.Count != 0)
                {
                    averageRating = plant.Value.Average();
                }
                Console.WriteLine($"- {plantName}; Rarity: {currentRarity}; Rating: {averageRating:f2}");
            }
        }
    }
}
