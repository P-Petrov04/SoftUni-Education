using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProduct = Console.ReadLine();
            int countOfProdukts = int.Parse(Console.ReadLine());

            CalculatingPrice(typeProduct, countOfProdukts);
        }

        static void CalculatingPrice(string product, int count)
        {
            double price = 0;

            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2.00;
            }

            Console.WriteLine($"{(price * count):f2}");
        }
    }
}
