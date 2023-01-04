using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class User
    {
        public User(string username, int count)
        {
            this.Username = username;
            this.CountMessages = count;
        }
        public string Username { get; set; }

        public int CountMessages { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userArgs = new Dictionary<string, int>();
          
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                string[] commandArgs = command.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string typeCommand = commandArgs[0];
                if (typeCommand == "Add")
                {
                    string username = commandArgs[1];
                    int sent = int.Parse(commandArgs[2]);
                    int received = int.Parse(commandArgs[3]);

                    if (!userArgs.ContainsKey(username))
                    {
                        userArgs[username] = sent + received;
                    }
                }
                else if (typeCommand == "Message")
                {
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (userArgs.ContainsKey(sender) && userArgs.ContainsKey(receiver))
                    {
                        userArgs[sender] += 1;
                        if (userArgs[sender] >= capacity)
                        {
                            userArgs.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        userArgs[receiver] += 1;
                        if (userArgs[receiver] >= capacity)
                        {
                            userArgs.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if (typeCommand == "Empty")
                {
                    string username = commandArgs[1];
                    if (username == "All")
                    {
                        userArgs.Clear();
                    }
                    else if (userArgs.ContainsKey(username))
                    {
                        userArgs.Remove(username);
                    }
                   
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {userArgs.Count}");
            if (userArgs.Count != 0)
            {
                foreach (var user in userArgs)
                {
                    Console.WriteLine($"{user.Key} - {user.Value}");
                }
            } 
        }
    }
}
