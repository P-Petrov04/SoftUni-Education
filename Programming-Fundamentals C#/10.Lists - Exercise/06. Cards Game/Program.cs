using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int originalCount = numbers1.Count;
            while(numbers1.Count != 0 && numbers2.Count != 0)
            {
                for (int i = 0; i < originalCount; i++)
                {
                    if (numbers1.Count == 0 || numbers2.Count == 0)
                    {
                        break;
                    }
                    int currentNumFromFirstHand = numbers1[0];
                    int currentNumFromSecondHand = numbers2[0];

                    if (currentNumFromFirstHand == currentNumFromSecondHand)
                    {
                        numbers1.RemoveAt(0);
                        numbers2.RemoveAt(0);
                    }
                    else if (currentNumFromFirstHand > currentNumFromSecondHand)
                    {
                        numbers1.Add(currentNumFromSecondHand);
                        int winNum = currentNumFromFirstHand;
                        numbers1.Remove(currentNumFromFirstHand);
                        numbers1.Add(winNum);
                        numbers2.Remove(currentNumFromSecondHand);
                    }
                    else if (currentNumFromSecondHand > currentNumFromFirstHand)
                    {
                        numbers2.Add(currentNumFromFirstHand);
                        int winNum = currentNumFromSecondHand;
                        numbers2.Remove(currentNumFromSecondHand);
                        numbers2.Add(winNum);
                        numbers1.Remove(currentNumFromFirstHand);
                    }
                }
            }
            
            int sum = 0;
            if (numbers1.Count != 0)
            {
                sum = numbers1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                sum = numbers2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }


        }
    }
}
