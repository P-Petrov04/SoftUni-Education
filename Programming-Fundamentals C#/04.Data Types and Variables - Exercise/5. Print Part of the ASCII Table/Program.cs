using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                char symbol = (char)i;
                Console.Write($"{symbol} ");
            }
        }
    }
}
