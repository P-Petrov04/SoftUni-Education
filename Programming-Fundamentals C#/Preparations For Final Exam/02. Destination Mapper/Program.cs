using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)(?<place>[A-Z][A-Za-z]{2,})\1";
            string places = Console.ReadLine();

            List<string> allValidPlaces = new List<string>();
            int travelPoints = 0;
            MatchCollection matchesPlaces = Regex.Matches(places, pattern);

            foreach (Match place in matchesPlaces)
            {
                travelPoints += place.Groups["place"].Value.Length;
                allValidPlaces.Add(place.Groups["place"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", allValidPlaces)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
