using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbersArray[i]} ");
            }
            Console.WriteLine();


        }
    }
}
