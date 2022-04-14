using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= countNumber; i++)
            {
                int number = i;
                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
                sum = 0;
            }

        }
    }
}
