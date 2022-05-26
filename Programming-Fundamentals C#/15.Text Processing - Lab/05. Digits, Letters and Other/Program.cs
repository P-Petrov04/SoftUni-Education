using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            string letters = string.Empty;
            string digits = string.Empty;
            string otherSymbols = string.Empty;

            foreach (char ch in symbols)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    otherSymbols += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherSymbols);
        }
    }
}
