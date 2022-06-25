using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                string currentStr = sequence[i];
                char letterBefore = currentStr[0];
                char letterAfter = currentStr[currentStr.Length - 1];
                decimal number = decimal.Parse(currentStr.Substring(1, currentStr.Length - 2));

                int placeOfFirstLetter = GetLetterPlace(letterBefore);
                int placeOfSecondLetter = GetLetterPlace(letterAfter);

                if (char.IsUpper(letterBefore))
                {
                    number = number / placeOfFirstLetter;
                }
                else
                {
                    number = number * placeOfFirstLetter;
                }

                if (char.IsUpper(letterAfter))
                {
                    number = number - placeOfSecondLetter;
                }
                else
                {
                    number = number + placeOfSecondLetter;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }

        static int GetLetterPlace(char letter)
        {
            int index = char.ToLower(letter) - 96;
            return index;
        }
    }
}
