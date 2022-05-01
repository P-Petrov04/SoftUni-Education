using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 1; i <= countWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordsAndSynonyms.ContainsKey(word))
                {
                    wordsAndSynonyms[word].Add(synonym);
                }
                else
                {
                    wordsAndSynonyms.Add(word, new List<string>());
                    wordsAndSynonyms[word].Add(synonym);
                }
            }

            foreach (var word in wordsAndSynonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
