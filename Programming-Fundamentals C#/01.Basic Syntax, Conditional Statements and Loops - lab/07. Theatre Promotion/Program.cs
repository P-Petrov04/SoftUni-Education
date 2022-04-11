using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int priceForTicket = 0;

            if (typeOfDay == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    priceForTicket = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    priceForTicket = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    priceForTicket = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    priceForTicket = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    priceForTicket = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    priceForTicket = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                if (age >= 0 && age <= 18)
                {
                    priceForTicket = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    priceForTicket = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    priceForTicket = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

            if (priceForTicket != 0)
            {
            Console.WriteLine($"{priceForTicket}$");
            }
                    
        }
    }
}
