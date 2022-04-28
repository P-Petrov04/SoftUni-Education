using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int numberOfMessages = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i <= numberOfMessages; i++)
            {
                int randomIndexOfPhrases = random.Next(0, phrases.Count);
                int randomIndexOfEvents = random.Next(0, events.Count);
                int randomIndexOfAuthors = random.Next(0, authors.Count);
                int randomIndexOfCities = random.Next(0, cities.Count);

                Console.WriteLine($"{phrases[randomIndexOfPhrases]} " +
                    $"{events[randomIndexOfEvents]} " +
                    $"{authors[randomIndexOfAuthors]} – " +
                    $"{cities[randomIndexOfCities]}.");
            }
        }
    }
}
