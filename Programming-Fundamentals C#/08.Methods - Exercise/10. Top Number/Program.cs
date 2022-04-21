using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= number; currentNum++)
            {
                bool isTopNumber = CheckNumber(currentNum);

                if (isTopNumber == true)
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        static bool CheckNumber (int currentNum)
        {
            if (SumOfDigitsDivisibleBy8(currentNum))
            {
                if (CheckForOddDigit(currentNum))
                {
                    return true;
                }
            }
            return false;
        }
        static bool SumOfDigitsDivisibleBy8 (int currentNum)
        {
            int sum = 0;
            while (currentNum != 0)
            {
                int currentDigit = currentNum % 10;
                sum += currentDigit;
                currentNum /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool CheckForOddDigit (int currentNum)
        {
            int oddDigitsCount = 0;
            while (currentNum != 0)
            {
                int currentDigit = currentNum % 10;
                if (currentDigit % 2 != 0)
                {
                    oddDigitsCount++;
                }
                currentNum /= 10;
            }

            if (oddDigitsCount >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
