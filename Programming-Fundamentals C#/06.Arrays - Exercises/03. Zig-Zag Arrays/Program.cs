using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int[] arr1 = new int[countOfLines]; 
            int[] arr2 = new int[countOfLines]; 

            for (int line = 0; line < countOfLines; line++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if(line % 2 == 0)
                {
                    arr1[line] = numbers[0];
                    arr2[line] = numbers[1];
                }
                else
                {
                    arr1[line] = numbers[1];
                    arr2[line] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
