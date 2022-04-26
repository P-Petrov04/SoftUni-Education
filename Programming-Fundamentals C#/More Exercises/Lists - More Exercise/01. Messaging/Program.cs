using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            
            string newText = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                int sum = 0;
                while (currNum != 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }

                while (sum > text.Length)
                {
                    sum -= text.Length;
                }
                int index = sum;
                char currCh = text[index];
                newText += currCh;
                text = text.Remove(index, 1);
            }

            Console.WriteLine(newText);
        }
    }
}
