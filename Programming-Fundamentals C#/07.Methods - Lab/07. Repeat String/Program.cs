using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        private static object stringBuilder;

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int countRepeats = int.Parse(Console.ReadLine());

            Console.WriteLine(ReapeaingString(text, countRepeats));
        }

        static string ReapeaingString(string text, int repeat) //fast way
        {
            StringBuilder repeatedString = new StringBuilder();

            for (int i = 0; i < repeat; i++)
            {
                repeatedString.Append(text);
            }

            return repeatedString.ToString();
        }

        //static string RepeatStringSlow(string inputString, int repeatNumber) //slow way
        //{
        //    string result = string.Empty;
        //    for (int i = 0; i < repeatNumber; i++)
        //    {
        //        result += inputString;
        //    }

        //    return result;
        //}
    }
}
