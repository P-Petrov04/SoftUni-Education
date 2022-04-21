using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                char middleCh = LenghtIsOdd(input);
                Console.WriteLine(middleCh);
            }
            else
            {
                char[] middleCh = LenghtIsEven(input);
                Console.WriteLine(string.Join("", middleCh));
            }
        }

        static char LenghtIsOdd (string input)
        {
            char middleCh = '.';
                for (int i = 0; i < input.Length; i++)
                {
                    char currentCh = input[i];
                    int charsBeforeCurrentChar = 0;
                    int charsAfterCurrentChar = 0;

                    for (int j = 0; j < i; j++)
                    {
                        charsBeforeCurrentChar++;
                    }
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        charsAfterCurrentChar++;
                    }

                    if (charsBeforeCurrentChar == charsAfterCurrentChar)
                    {
                        middleCh = currentCh;
                        break;
                    }
                }
            
            return middleCh;
        }

        static char[] LenghtIsEven (string input)
        {
            char[] middleChArray = new char[2];

            for (int i = 0; i < input.Length; i++)
            {
                char currentCh = input[i];
                int charsBeforeCurrentChar = 0;
                int charsAfterCurrentChar = 0;

                for (int j = 0; j < i; j++)
                {
                    charsBeforeCurrentChar++;
                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    charsAfterCurrentChar++;
                }

                if (charsBeforeCurrentChar - charsAfterCurrentChar == -1)
                {
                    middleChArray[0] = input[i];
                    middleChArray[1] = input[i + 1];
                }
            }
            return middleChArray;
        }
    }
}
