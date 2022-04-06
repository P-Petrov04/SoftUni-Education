using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //град   coffee water   beer sweets  peanuts
            //Sofia   0.50  0.80    1.20  1.45    1.60
            //Plovdiv 0.40  0.70    1.15  1.30    1.50
            //Varna   0.45  0.70    1.10  1.35    1.55

            string produkt = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double price = 0;

            switch (city)
            {
                case "Sofia":
                    if (produkt == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (produkt == "water")
                    {
                        price = 0.80;
                    }
                    else if (produkt == "beer")
                    {
                        price = 1.20;
                    }
                    else if (produkt == "sweets")
                    {
                        price = 1.45;
                    }
                    else if (produkt == "peanuts")
                    {
                        price = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (produkt == "coffee")
                    {
                        price = 0.40;
                    }
                    else if (produkt == "water")
                    {
                        price = 0.70;
                    }
                    else if (produkt == "beer")
                    {
                        price = 1.15;
                    }
                    else if (produkt == "sweets")
                    {
                        price = 1.30;
                    }
                    else if (produkt == "peanuts")
                    {
                        price = 1.50;
                    }
                    break;
                case "Varna":
                    if (produkt == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (produkt == "water")
                    {
                        price = 0.70;
                    }
                    else if (produkt == "beer")
                    {
                        price = 1.10;
                    }
                    else if (produkt == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (produkt == "peanuts")
                    {
                        price = 1.55;
                    }
                    break;
            }

            double finalPrice = count * price;
            Console.WriteLine(finalPrice);


        }
    }
}
