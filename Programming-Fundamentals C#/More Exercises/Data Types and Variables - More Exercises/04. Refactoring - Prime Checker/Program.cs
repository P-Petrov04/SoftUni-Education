using System;

namespace _04._Refactoring___Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= givenNum; currentNum++)
            {
                bool isPrime = true;
                for (int i = 2; i < currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime.ToString().ToLower()}", currentNum, isPrime);
            }

        }
    }
}
