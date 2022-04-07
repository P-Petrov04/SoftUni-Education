using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double money = 0;
            
            while (input != "NoMoreMoney")
            {
                double num = double.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {num:f2}");
                money += num;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {money:f2}");
        }
    }
}
