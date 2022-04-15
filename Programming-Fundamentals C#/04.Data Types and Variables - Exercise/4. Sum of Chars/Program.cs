using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSimbols = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= countSimbols; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int numOFLetter = (int)letter;
                sum += numOFLetter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
