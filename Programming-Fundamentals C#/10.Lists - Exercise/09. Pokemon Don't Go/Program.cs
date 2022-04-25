using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumOfRemovedElements = 0;

            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedNum = 0;
                if (index < 0)
                {
                    removedNum = numbers[0];
                    sumOfRemovedElements += removedNum;
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index >= numbers.Count)
                {
                    removedNum = numbers[numbers.Count - 1];
                    sumOfRemovedElements += removedNum;
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers[0]);
                }
                else
                {
                    removedNum = numbers[index];
                    sumOfRemovedElements += removedNum;
                    numbers.RemoveAt(index);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= removedNum)
                    {
                        numbers[i] += removedNum;
                    }
                    else
                    {
                        numbers[i] -= removedNum;
                    }
                }
            }

            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
