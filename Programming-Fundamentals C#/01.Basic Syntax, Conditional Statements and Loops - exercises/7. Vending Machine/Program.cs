using System;

namespace _7._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Start")
            {
                if (input == "2" || input == "1" || input == "0.5" || input == "0.2" || input == "0.1")
                {
                    sum += double.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            double price = 0;

            while (input2 != "End")
            {
                if (input2 == "Nuts")
                {
                    price = 2;
                }
                else if (input2 == "Water")
                {
                    price = 0.7;
                }
                else if (input2 == "Crisps")
                {
                    price = 1.5;
                }
                else if (input2 == "Soda")
                {
                    price = 0.8;
                }
                else if (input2 == "Coke")
                {
                    price = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                if (sum >= price && sum > 0 && price > 0)
                {
                    Console.WriteLine($"Purchased {input2.ToLower()}");
                    sum = sum - price;
                    price = 0;
                }
                else if (price > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    price = 0;
                }

                input2 = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
