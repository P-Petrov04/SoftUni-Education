using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            
            Dictionary<string, int> wordsOccurences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string currentWord = word.ToLower();
                if (wordsOccurences.ContainsKey(currentWord))
                {
                    wordsOccurences[currentWord] += 1;
                }
                else
                {
                    wordsOccurences.Add(currentWord, 1);
                }
            }

            foreach (var word in wordsOccurences)
            {
                if (word.Value % 2 == 0)
                {
                    wordsOccurences.Remove(word.Key);
                }
            }

            Console.WriteLine(string.Join(" ", wordsOccurences.Keys));
        }
    }
}
