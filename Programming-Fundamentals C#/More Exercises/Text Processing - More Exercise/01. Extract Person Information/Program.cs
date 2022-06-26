using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"\@(?<name>[A-Za-z]+)\|";
            string patternAge = @"\#(?<age>[0-9]+)\*";

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                Match matchName = Regex.Match(text, patternName);
                Match matchAge = Regex.Match(text, patternAge);

                Console.WriteLine($"{matchName.Groups["name"].Value} is {matchAge.Groups["age"].Value} years old.");
            }
        }
    }
}
