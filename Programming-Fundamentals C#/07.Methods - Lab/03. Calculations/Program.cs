using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string methodForCalculation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Calculating(methodForCalculation, number1, number2);
        }

        static void Calculating(string method, int firstNum, int secondNum)
        {
            if (method == "add")
            {
                Console.WriteLine($"{firstNum + secondNum}");
            }
            else if (method == "multiply")
            {
                Console.WriteLine($"{firstNum * secondNum}");
            }
            else if (method == "subtract")
            {
                Console.WriteLine($"{firstNum - secondNum}");
            }
            else if (method == "divide")
            {
                Console.WriteLine($"{firstNum / secondNum}");
            }
        }
    }
}
