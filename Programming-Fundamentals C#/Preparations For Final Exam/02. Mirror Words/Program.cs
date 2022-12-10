using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@|\#)(?<word>[A-Za-z]{3,})\1\1(?<mirror>[A-Za-z]{3,})\1";
            string message = Console.ReadLine();

            List<string[]> validMatches = new List<string[]>();
            MatchCollection matches = Regex.Matches(message, pattern);
            foreach (Match match in matches)
            {
                string firstWord = match.Groups["word"].Value;
                string mirrorWord = match.Groups["mirror"].Value;
                string reversedMirrorWord = string.Empty;
                //reversedMirrorWord = string.Join("", mirrorWord.Reverse()); - fast reverse
                for (int i = mirrorWord.Length - 1; i >= 0; i--)
                {
                    reversedMirrorWord += mirrorWord[i];
                }
                if (firstWord == reversedMirrorWord)
                {
                    validMatches.Add(new string[] {firstWord, mirrorWord});
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if (validMatches.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");

                    string[] matchesWords = validMatches
                        .Select(word => $"{word[0]} <=> {word[1]}")
                        .ToArray();

                    Console.WriteLine(string.Join(", ", matchesWords));
                }
            }
        }
    }
}
