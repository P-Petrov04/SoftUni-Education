using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char operationsSign = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Operating(number1, operationsSign, number2));
        }

        static int Operating(int num1, int operation, int num2)
        {
            int value = 0;
            if (operation == '/')
            {
                value = num1 / num2;
            }
            else if (operation == '-')
            {
                value = num1 - num2;
            }
            else if (operation == '+')
            {
                value = num1 + num2;
            }
            else if (operation == '*')
            {
                value = num1 * num2;
            }

            return value;
        }
    }
}
