using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputParentheses = Console.ReadLine();
            Stack<char> currentParetheses = new Stack<char>();
            bool isBalanced = true;
            foreach (char ch in inputParentheses)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    currentParetheses.Push(ch);
                    continue;
                }

                if (currentParetheses.Count == 0)
                {
                    isBalanced = false;
                    break;
                }
                else if (ch == ')' && currentParetheses.Peek() == '(')
                {
                    currentParetheses.Pop();
                }
                else if (ch == ']' && currentParetheses.Peek() == '[')
                {
                    currentParetheses.Pop();
                }
                else if (ch == '}' && currentParetheses.Peek() == '{')
                {
                    currentParetheses.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced && currentParetheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
