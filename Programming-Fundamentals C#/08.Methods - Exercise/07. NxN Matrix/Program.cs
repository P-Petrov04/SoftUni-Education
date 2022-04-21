using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            PrintMatrix(lenght);
        }

        static void PrintMatrix (int lenght)
        {
            for (int i = 1; i <= lenght; i++)
            {
                for (int j = 1; j <= lenght; j++)
                {
                    Console.Write(lenght + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
