using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            PrintSmallestNum(number1, number2, number3);
        }

        static void PrintSmallestNum(int num1,int num2,int num3)
        {
            if (num1 <= num2 & num1 <= num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 <= num1 & num2 <= num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 <= num1 & num3 <= num2)
            {
                Console.WriteLine(num3);
            }

            
        }
    }
}
