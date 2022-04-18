using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthSequence = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split("!");

            int counterOfSequence = 1;
            int maxCount = -1;
            int bestCounterSequence = 0;
            int bestSum = 0;
            int[] bestSequence = new int[lengthSequence];
            int sum = 0;

            while (input[0] != "Clone them")
            {
                int[] currentSequence = new int[input.Length];
                
                for (int i = 0; i < lengthSequence; i++)
                {
                    currentSequence[i] = int.Parse(input[i]);
                }

                for (int i = 0; i < currentSequence.Length; i++)
                {
                    int currentNum = currentSequence[i];
                    for (int j = i; j < currentSequence.Length - 1; j++)
                    {
                        int nextNum = currentSequence[j + 1];

                        if (currentNum != nextNum)
                        {
                            break;
                        }
                        if (currentNum == 1)
                        {
                        counterOfSequence++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    if (counterOfSequence >= maxCount)
                    {
                        maxCount = counterOfSequence;
                        bestSequence = currentSequence;
                    }

                    if (currentNum == 1)
                    {
                        sum += currentNum;
                    }
                    
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                    
                    if (counterOfSequence > bestCounterSequence)
                    {
                        bestCounterSequence = counterOfSequence;
                    }
                }

                input = Console.ReadLine().Split("!");
            }

            Console.WriteLine($"Best DNA sample {bestCounterSequence} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
            
        }
    }
}
