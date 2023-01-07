using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOperations = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string[]> operations = new Stack<string[]>();
            Stack<char> removedElements = new Stack<char>();
            for (int i = 0; i < countOperations; i++)
            {
                string[] operation = Console.ReadLine().Split();
                string typeOperation = operation[0];

                if (typeOperation == "1")
                {
                    string str = operation[1];
                    text += str;
                    operations.Push(operation);
                }
                else if (typeOperation == "2")
                {
                    int count = int.Parse(operation[1]);
                    for (int j = 0; j < count; j++)
                    {
                        removedElements.Push(text[text.Length - 1]);
                        text = text.Remove(text.Length - 1, 1);
                    }
                    operations.Push(operation);
                }
                else if (typeOperation == "3")
                {
                    int position = int.Parse(operation[1]);
                    Console.WriteLine(text[position - 1]);
                }
                else if (typeOperation == "4")
                {
                    string[] lastOperation = operations.Pop();
                    if (lastOperation[0] == "1")
                    {
                        string str = lastOperation[1];
                        for (int j = 0; j < str.Length; j++)
                        {
                            text = text.Remove(text.Length - 1, 1);
                        }
                    }
                    else
                    {
                        int count = int.Parse(lastOperation[1]);
                        for (int j = 0; j < count; j++)
                        {
                            text += removedElements.Pop();
                        }
                    }
                }
            }

            //Stack<string> stack = new Stack<string>();
            //StringBuilder sb = new StringBuilder();

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            //    string command = input[0];

            //    if (command == "1")
            //    {
            //        string strToAdd = input[1];
            //        stack.Push(sb.ToString());

            //        sb.Append(strToAdd);
            //    }

            //    else if (command == "2")
            //    {
            //        int count = int.Parse(input[1]);
            //        stack.Push(sb.ToString());

            //        sb.Remove(sb.Length - count, count);
            //    }

            //    else if (command == "3")
            //    {
            //        int numberOfElement = int.Parse(input[1]);

            //        Console.WriteLine(sb[numberOfElement - 1]);
            //    }

            //    else if (command == "4")
            //    {
            //        sb.Clear();
            //        sb.Append(stack.Pop());
            //    }

            //}
        }
    }
}
