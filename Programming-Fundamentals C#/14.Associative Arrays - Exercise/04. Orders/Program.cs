using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<decimal>> product = new Dictionary<string, List<decimal>>();

            while (input != "buy")
            {
                string[] productArg = input.Split();

                string productName = productArg[0];
                decimal price = decimal.Parse(productArg[1]);
                int quantity = int.Parse(productArg[2]);

                if (!product.ContainsKey(productName))
                {
                    product.Add(productName, new List<decimal>() {price, quantity});
                }
                else
                {
                    product[productName][0] = price;
                    product[productName][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in product)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}
