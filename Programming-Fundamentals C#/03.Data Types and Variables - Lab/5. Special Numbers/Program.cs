using System;

namespace _5._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                int num = i;
                while (num != 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num = num / 10;
                }
                
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
                sum = 0;
            }
        }
    }
}
