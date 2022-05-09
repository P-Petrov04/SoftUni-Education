using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<char> wordChars = new List<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    char currentChar = input[i];
                    wordChars.Add(currentChar);
                }

                wordChars.Reverse();
                string reversedWord = string.Empty;
                foreach (char ch in wordChars)
                {
                    reversedWord += ch;
                }

                //for (int i = input.Length - 1; i >= 0; i--)
                //{
                //    char currentChar = input[i];
                //    reversedWord += currentChar;
                //}

                Console.WriteLine($"{input} = {reversedWord}");
                input = Console.ReadLine();
            }
        }
    }
}
