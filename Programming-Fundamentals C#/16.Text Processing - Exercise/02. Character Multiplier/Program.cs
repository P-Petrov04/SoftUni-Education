using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string firstString = strings[0];
            string secondString = strings[1];

            int sum = 0;

            if (firstString.Length == secondString.Length)
            {
                sum = SumCalculation(sum, firstString, secondString);
            }
            else if (firstString.Length > secondString.Length)
            {
                sum = SumCalculation(sum, firstString, secondString);

                int difference = firstString.Length - secondString.Length;
                string left = firstString.Substring(secondString.Length, difference);

                for (int i = 0; i < difference; i++)
                {
                    char currentChar = left[i];
                    sum += currentChar;
                }
            }
            else
            {
                sum = SumCalculationSecondStr(sum, firstString, secondString);

                int difference = secondString.Length - firstString.Length;
                string left = secondString.Substring(firstString.Length, difference);

                for (int i = 0; i < difference; i++)
                {
                    char currentChar = left[i];
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);
        }

         static int SumCalculation(int sum, string firstStr, string secondStr)
         {
            for (int i = 0; i < secondStr.Length; i++)
            {
                char currentCharFirstStr = firstStr[i];
                char currentCharSecondStr = secondStr[i];
                int chCodeFirstStr = currentCharFirstStr;
                int chCodeSecondStr = currentCharSecondStr;

                int value = chCodeFirstStr * chCodeSecondStr;

                sum += value;
            }

            return sum;
         }

        static int SumCalculationSecondStr(int sum, string firstStr, string secondStr)
        {
            for (int i = 0; i < firstStr.Length; i++)
            {
                char currentCharFirstStr = firstStr[i];
                char currentCharSecondStr = secondStr[i];
                int chCodeFirstStr = currentCharFirstStr;
                int chCodeSecondStr = currentCharSecondStr;

                int value = chCodeFirstStr * chCodeSecondStr;

                sum += value;
            }

            return sum;
        }
    }
}
