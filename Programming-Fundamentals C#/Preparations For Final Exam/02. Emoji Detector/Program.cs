using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterForEmojies = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
            string patterForDigits = @"\d";

            string input = Console.ReadLine();
            List<string> coolestEmojies = new List<string>();

            BigInteger coolThreshold = 1;
            MatchCollection matchedNumbers = Regex.Matches(input, patterForDigits);
            foreach (Match number in matchedNumbers)
            {
                coolThreshold = BigInteger.Multiply(coolThreshold, BigInteger.Parse(number.Value));
            }

            MatchCollection matchedEmojies = Regex.Matches(input, patterForEmojies);
            foreach (Match emoji in matchedEmojies)
            {
                string currentEmoji = emoji.Groups["emoji"].Value;
                int chPower = 0;
                foreach (char ch in currentEmoji)
                {
                    chPower += ch;
                }
                if (chPower >= coolThreshold)
                {
                    coolestEmojies.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matchedEmojies.Count} emojis found in the text. The cool ones are:");
            foreach (string emoji in coolestEmojies)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
