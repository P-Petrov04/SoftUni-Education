using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int line = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double price = 0;
            //column * line * price

            if (projection == "Premiere")
            {
                price = 12;
            }
            else if(projection == "Normal")
            {
                price = 7.50;
            }
            else if (projection == "Discount")
            {
                price = 5;
            }
            double fullPrice = line * column * price;
            Console.WriteLine($"{fullPrice:f2} leva");
        }
    }
}
