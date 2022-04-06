using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());

            if (fuel >= 25)
            {
                if (typeFuel == "Diesel")
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else if ( typeFuel == "Gasoline")
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else if ( typeFuel == "Gas")
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
            else 
            {
                if (typeFuel == "Diesel")
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
                else if (typeFuel == "Gasoline")
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
                else if (typeFuel == "Gas")
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
                
            }
         
        }
    }
}
