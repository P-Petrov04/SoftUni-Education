using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})([\.|\/|-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string dates = Console.ReadLine();

            MatchCollection matches = Regex.Matches(dates, pattern);
            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
                //Day: 13, Month: Jul, Year: 1928
            }
        }
    }
}
