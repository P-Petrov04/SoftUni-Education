using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\>\>(?<name>[A-za-z]+)\<\<(?<price>\d+(\.\d+)*?)\!(?<quantity>\d+(\.\d+)*?)";
            List<string> matches = new List<string>();
            decimal finalPrice = 0;
            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    finalPrice += price * (decimal)quantity;
                    matches.Add(name);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (string match in matches)
            {
                Console.WriteLine(match);
            }
            Console.WriteLine($"Total money spend: {finalPrice:f2}");
        }
    }
}
