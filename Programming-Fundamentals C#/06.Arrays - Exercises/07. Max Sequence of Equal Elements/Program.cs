using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentNum = -1;
            int maxLength = -1;
            int numOfSequence = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentNum = numbers[i];
                int sequenceCounter = 1;

                for (int j = i; j < numbers.Length - 1; j++)
                {
                    int nextNum = numbers[j + 1];

                    if (currentNum != nextNum)
                    {
                        break;
                    }
                    sequenceCounter++;
                }

                int[] currentSequence = new int[sequenceCounter];

                if (maxLength < currentSequence.Length)
                {
                    maxLength = currentSequence.Length;
                    numOfSequence = currentNum;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{numOfSequence} ");
            }
        }
    }
}
