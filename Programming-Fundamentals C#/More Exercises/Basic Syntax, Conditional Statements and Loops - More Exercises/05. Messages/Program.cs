using System;
using System.Text;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                int countOfDigits = digits.Length;
                char digit = digits[0];
                int mainDigit = (int)Char.GetNumericValue(digit);
                if(mainDigit == 0)
                {
                    message.Append(" ");
                }
                else
                {
                    int offSet = (mainDigit - 2) * 3;
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offSet++;
                    }
                    int letterIndex = offSet + countOfDigits - 1;
                    char myLetter = (char)(97 + letterIndex);

                    message.Append(myLetter);
                }
            }

            Console.WriteLine(message);
        }
    }
}
