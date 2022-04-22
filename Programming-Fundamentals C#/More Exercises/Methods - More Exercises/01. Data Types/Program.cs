using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();

            if (input == "int")
            {
                int result = int.Parse(secondInput) * 2;
                Console.WriteLine(result);
            }
            else if (input == "real")
            {
                double result = double.Parse(secondInput) * 1.5;
                Console.WriteLine($"{result:f2}");
            }
            else if (input == "string")
            {
                Console.WriteLine($"${secondInput}$");
            }

        }
    }
}
