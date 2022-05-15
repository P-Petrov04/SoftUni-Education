using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(wordToRemove))
            {
                int indexOfWordToRemove = word.IndexOf(wordToRemove);
                word = word.Remove(indexOfWordToRemove, wordToRemove.Length);
            }

            Console.WriteLine(word);
        }
    }
}
