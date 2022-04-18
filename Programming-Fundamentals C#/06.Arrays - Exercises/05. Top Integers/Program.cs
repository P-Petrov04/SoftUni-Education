using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] <= numbers[j + 1])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            

            //var arr = Console.ReadLine()
            //            .Split()
            //            .Select(int.Parse)
            //            .ToArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    var currentNumber = arr[i];
            //    var isItBigger = true;
            //    for (int k = i + 1; k < arr.Length; k++)
            //    {
            //        if (currentNumber <= arr[k])
            //        {
            //            isItBigger = false;
            //        }
            //    }
            //    if (isItBigger)
            //    {
            //        Console.Write($"{arr[i]} ");
            //    }
            //}

        }
    }
}
