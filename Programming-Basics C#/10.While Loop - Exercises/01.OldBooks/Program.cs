using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int couter = 0;
            string input = Console.ReadLine();

            while (input != "No More Books")
            {
                if (input == favouriteBook)
                {
                    break;
                }
                couter++;
                input = Console.ReadLine();
            }
            if (input == favouriteBook)
            {
                Console.WriteLine($"You checked {couter} books and found it.");
            }
            else 
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {couter} books.");
            }
        }
    }
}
