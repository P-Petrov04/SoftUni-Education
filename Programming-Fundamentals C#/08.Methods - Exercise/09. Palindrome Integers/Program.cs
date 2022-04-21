using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input=Console.ReadLine()) != "END")
            {
                string reversedInput = ReverseString(input);

                if (reversedInput == input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static string ReverseString (string input)
        {
            string reversedInput = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currentCh = input[i];
                reversedInput += currentCh;
            }

            return reversedInput;
        }
    }
}
