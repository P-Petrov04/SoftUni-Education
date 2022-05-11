using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string repeatedWords = string.Empty;
            //StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    repeatedWords += word;
                    //result.Append(word);
                }
            }

            Console.WriteLine(repeatedWords);
            //Console.WriteLine(result);
        }
    }
}
