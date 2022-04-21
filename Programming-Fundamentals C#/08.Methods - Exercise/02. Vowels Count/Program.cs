using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.ToLower();
            Console.WriteLine(CountVowels(text));
        }

        static int CountVowels(string text)
        {
            int vowelsCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentLabel = text[i];

                if (currentLabel == 'a' || currentLabel == 'e' || currentLabel == 'i' || currentLabel == 'o' || currentLabel == 'u' || currentLabel == 'y')
                {
                    vowelsCounter++;
                }
            }

            return vowelsCounter;
        }
    }
}
