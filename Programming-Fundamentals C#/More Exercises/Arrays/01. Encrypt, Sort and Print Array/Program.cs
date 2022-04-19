using System;
using System.Collections.Generic;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<char> vowelLetters = new List<char>()
            {
                'a',
                'e',
                'o',
                'i',
                'u',
                'A',
                'E',
                'O',
                'I',
                'U'
            };
            List<int> allSums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                int sum = 0;
                foreach (char ch in str)
                {
                    if (vowelLetters.Contains(ch))
                    {
                        sum += (int)ch * str.Length;
                    }
                    else
                    {
                        sum += (int)ch / str.Length;
                    }
                }

                allSums.Add(sum);
            }

            allSums.Sort();
            foreach (var sum in allSums)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
