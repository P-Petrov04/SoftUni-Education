using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int countOfReadedLines = 0;
            int quantity = 0;
            string resource = string.Empty;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                countOfReadedLines++;
                
                if (countOfReadedLines % 2 != 0)
                {
                    resource = input;
                    if (!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, 0);
                    }
                }
                else
                {
                    quantity = int.Parse(input);
                    resources[resource] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
