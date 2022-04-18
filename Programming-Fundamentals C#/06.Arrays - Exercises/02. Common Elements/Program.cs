using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            for (int indexArr2 = 0; indexArr2 <= arr2.Length - 1; indexArr2++)
            {
                for (int indexArr1 = 0; indexArr1 <= arr1.Length - 1; indexArr1++)
                {
                    if (arr2[indexArr2] == arr1[indexArr1])
                    {
                        Console.Write($"{arr2[indexArr2]} ");
                    }
                }
            }
        }
    }
}
