using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double factOne = FactorialOfFirstNum(number1);
            double factTwo = FactorialOfSecondNum(number2);
            double finalValue = DevideFactorial1ToFactorial2(factOne, factTwo);

            Console.WriteLine($"{finalValue:f2}");
        }

        static double DevideFactorial1ToFactorial2(double factorial1, double factorial2)
        {
            double devide = factorial1 / factorial2;
            return devide;
        }

        static double FactorialOfFirstNum(int num1)
        {
            double factorial = 1;
            for (int i = 2; i <= num1; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        static double FactorialOfSecondNum(int num2)
        {
            double factorial = 1;
            for (int i = 2; i <= num2; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}

