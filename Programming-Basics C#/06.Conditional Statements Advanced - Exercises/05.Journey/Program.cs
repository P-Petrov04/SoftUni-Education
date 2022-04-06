using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujed = double.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();

            string destination = "";
            string typeVacation = "";
            double price = 0;

            if (bujed <= 100)
            {
                destination = "Bulgaria";

                if(seasons == "summer")
                {
                    typeVacation = "Camp";
                    price = bujed * 0.3;
                }
                else if (seasons == "winter")
                {
                    typeVacation = "Hotel";
                    price = bujed * 0.7;
                }

            }
            else if ( bujed <= 1000)
            {
                destination = "Balkans";

                if (seasons == "summer")
                {
                    typeVacation = "Camp";
                    price = bujed * 0.4;
                }
                else if (seasons == "winter")
                {
                    typeVacation = "Hotel";
                    price = bujed * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                typeVacation = "Hotel";
                price = bujed * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVacation} - {price:f2}");
        }
    }
}
