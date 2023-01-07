using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < str.Length; i++)
            {
                char currCh = str[i];
                if (currCh == '(')
                {
                    indexes.Push(i);
                }
                else if (currCh == ')')
                {
                    int startIndex = indexes.Pop();
                    int endIndex = i;
                    string subStr = str.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subStr);
                }
            }
        }
    }
}
