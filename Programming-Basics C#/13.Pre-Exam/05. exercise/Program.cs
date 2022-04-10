using System;

namespace _05._exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int purpose = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int money = 0;

            while (input != "closed")
            {
                string type = Console.ReadLine();
                if (input == "haircut")
                {
                    if(type == "mens")
                    {
                        money += 15;
                    }
                    else if (type == "ladies")
                    {
                        money += 20;
                    }
                    else 
                    {
                        money += 10;
                    }
                }
                else if (input == "color")
                {
                    if (type == "touch up")
                    {
                        money += 20;
                    }
                    else
                    {
                        money += 30;
                    }
                }

                if (money >= purpose)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {money}lv.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "closed")
            {
                Console.WriteLine($"Target not reached! You need {purpose - money}lv. more.");
                Console.WriteLine($"Earned money: {money}lv.");
            }
        }
    }
}
