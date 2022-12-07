using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\||\#])(?<name>[A-Za-z]+ *[A-Za-z]*)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";

            string input = Console.ReadLine();
            int allCalories = 0;

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                allCalories += calories;
            }

            int days = allCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}" +
                    $", Best before: {match.Groups["date"].Value}" +
                    $", Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
