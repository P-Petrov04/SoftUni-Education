using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] arguments = input.Split(" -> ");

                string companyName = arguments[0];
                string id = arguments[1];

                if (companyUsers.ContainsKey(companyName))
                {
                    if (companyUsers[companyName].Contains(id))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    companyUsers[companyName].Add(id);
                }
                else
                {
                    companyUsers.Add(companyName, new List<string>() { id });
                }

                input = Console.ReadLine();
            }

            foreach (var item in companyUsers)
            {
                Console.WriteLine($"{item.Key}");
                string[] users = item.Value.ToArray();
                foreach (var user in users)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
