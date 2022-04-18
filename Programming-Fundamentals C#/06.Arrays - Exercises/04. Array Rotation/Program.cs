using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOfRotations = int.Parse(Console.ReadLine());

            int[] numbersAfterRotations = numbers;

            for (int index = 0; index < countOfRotations; index++)
            {
                int firstNum = numbersAfterRotations[0];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbersAfterRotations[i] = numbers[i + 1];
                }
                numbersAfterRotations[numbers.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", numbersAfterRotations));
        }
    }
}
