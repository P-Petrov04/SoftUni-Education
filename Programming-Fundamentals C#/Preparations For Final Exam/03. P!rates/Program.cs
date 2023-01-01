using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityInfo = Console.ReadLine();
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (cityInfo != "Sail")
            {
                string[] cityArgs = cityInfo.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = cityArgs[0];
                int population = int.Parse(cityArgs[1]);
                int gold = int.Parse(cityArgs[2]);

                if (cities.ContainsKey(cityName))
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }
                else
                {
                    cities.Add(cityName, new List<int>());
                    cities[cityName].Add(population);
                    cities[cityName].Add(gold);
                }

                cityInfo = Console.ReadLine();
            }

            string eventCommand = Console.ReadLine();
            while (eventCommand != "End")
            {
                string[] eventCommandArgs = eventCommand
                    .Split("=>",StringSplitOptions.RemoveEmptyEntries);

                string typeEvent = eventCommandArgs[0];
                if (typeEvent == "Plunder")
                {
                    string currentTown = eventCommandArgs[1];
                    int populationToKill = int.Parse(eventCommandArgs[2]);
                    int goldToSteal= int.Parse(eventCommandArgs[3]);

                    cities[currentTown][0] -= populationToKill;
                    cities[currentTown][1] -= goldToSteal;
                    Console.WriteLine($"{currentTown} plundered! {goldToSteal} gold stolen, {populationToKill} citizens killed.");
                    if (cities[currentTown][0] == 0 || cities[currentTown][1] == 0)
                    {
                        cities.Remove(currentTown);
                        Console.WriteLine($"{currentTown} has been wiped off the map!");
                    }
                }
                else if (typeEvent == "Prosper")
                {
                    string currentTown = eventCommandArgs[1];
                    int goldToInvest = int.Parse(eventCommandArgs[2]);

                    if (goldToInvest < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[currentTown][1] += goldToInvest;
                        Console.WriteLine($"{goldToInvest} gold added to the city treasury. {currentTown} now has {cities[currentTown][1]} gold.");
                    }
                }

                eventCommand = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
