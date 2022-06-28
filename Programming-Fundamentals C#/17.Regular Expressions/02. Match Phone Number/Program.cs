using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phones, pattern);
            List<string> listOfNumbers = new List<string>();

            foreach (Match match in matches)
            {
                listOfNumbers.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", listOfNumbers));
        }
    }
}
