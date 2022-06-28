using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<customer>[A-Z]{1}[a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)*?)\$";

            decimal finalPrice = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalPrice = price * count;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    finalPrice += totalPrice;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {finalPrice:f2}");
        }
    }
}
