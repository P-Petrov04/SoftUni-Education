using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double price = 0;

            if (typeRoom == "room for one person")
            {
                price = (days - 1) * 18;
            }
            else if (typeRoom == "apartment")
            {
                price = (days - 1) * 25;

                if (days < 10)
                {
                    price = price - price * 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - price * 0.35;
                }
                else
                {
                    price = price - price * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                price = (days - 1) * 35;

                if (days < 10)
                {
                    price = price - price * 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - price * 0.15;
                }
                else
                {
                    price = price - price * 0.2;
                }
            }
            if (evaluation == "positive")
            {
                price = price + price * 0.25;
            }
            else if (evaluation == "negative")
            {
                price = price - price * 0.10;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
