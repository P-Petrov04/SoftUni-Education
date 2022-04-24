using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 1; i <= countOfProducts; i++)
            {
                string typeProduct = Console.ReadLine();
                products.Add(typeProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
