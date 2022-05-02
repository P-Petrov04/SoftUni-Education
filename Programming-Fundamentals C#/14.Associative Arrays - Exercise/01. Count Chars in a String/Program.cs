using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            foreach (string word in words)
            {
                foreach (char symbol in word)
                {
                    if (charsCount.ContainsKey(symbol))
                    {
                        charsCount[symbol] += 1;
                    }
                    else
                    {
                        charsCount.Add(symbol, 1);
                    }
                }
            }

            foreach (var item in charsCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
