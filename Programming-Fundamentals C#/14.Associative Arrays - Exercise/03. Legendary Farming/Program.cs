using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);
            Dictionary<string, int> junks = new Dictionary<string, int>();

            Dictionary<string, int> materialForLegendaryItem = new Dictionary<string, int>();

            int quantity = 0;
            string material = string.Empty;
            int inputInRoll = 0;

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split();
                for (int i = 0; i < inputArr.Length; i++)
                {
                    inputInRoll++;
                    if (inputInRoll % 2 != 0)
                    {
                        quantity = int.Parse(inputArr[i]);
                    }
                    else
                    {
                        material = inputArr[i].ToLower();

                        if (keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] += quantity;
                            if (keyMaterials.Any(material => material.Value >= 250))
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (!junks.ContainsKey(material))
                            {
                                junks.Add(material, quantity);
                            }
                            else
                            {
                                junks[material] += quantity;
                            }
                        }
                    }
                }

                if (keyMaterials.Any(material => material.Value >= 250))
                {
                    break;
                }
            }

            string legendaryItem = string.Empty;
            foreach (var item in keyMaterials)
            {
                materialForLegendaryItem.Add(item.Key, item.Value);
            }
            foreach (var item in materialForLegendaryItem)
            {
                if (item.Value < 250)
                {
                    materialForLegendaryItem.Remove(item.Key);
                }
                else
                {
                    if (item.Key == "shards")
                    {
                        legendaryItem = "Shadowmourne";
                        keyMaterials["shards"] -= 250;
                    }
                    else if (item.Key == "fragments")
                    {
                        legendaryItem = "Valanyr";
                        keyMaterials["fragments"] -= 250;
                    }
                    else
                    {
                        legendaryItem = "Dragonwrath";
                        keyMaterials["motes"] -= 250;
                    }
                }
            }

            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
