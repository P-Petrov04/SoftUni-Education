using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNumber = int.MinValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
