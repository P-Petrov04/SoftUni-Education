using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            
            Console.WriteLine(SumEvenNumbers(number) * SumOddNumbers(number));
        }

        static int SumEvenNumbers(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                number = number / 10;
            }

            return sum;
        }

       static int SumOddNumbers(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }

                number = number / 10;
            }

            return sum;
        }
    }
}
