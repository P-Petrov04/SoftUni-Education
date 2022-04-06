using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if (days > 7 && days <= 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.05;
                }
                else if (days > 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.3;
                    priceApartment = priceApartment - priceApartment * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;

                if (days > 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.2;
                    priceApartment = priceApartment - priceApartment * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;

                if (days > 14)
                {
                    priceApartment = priceApartment - priceApartment * 0.1;
                }
            }

            double finalPriceStudio = days * priceStudio;
            double finalPriceApartment = days * priceApartment;

            Console.WriteLine($"Apartment: {finalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
        }
    }
}
