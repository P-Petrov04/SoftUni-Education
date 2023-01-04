using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@+|\#+)(?<colour>[a-z]{3,})(\@+|\#+)([^a-zA-Z0-9]*|.*?)(\/+)(?<amount>[0-9]+)/3";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine($"You found {item.Groups["amount"].Value} {item.Groups["colour"].Value} eggs!");
            }
        }
    }
}
