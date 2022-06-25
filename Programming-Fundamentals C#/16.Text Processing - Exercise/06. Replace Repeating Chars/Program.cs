using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char currCh = text[i];
                int count = 0;
                for (int y = i + 1; y < text.Length; y++)
                {
                    if (text[y] == currCh)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                text = text.Remove(i, count);
            }

            Console.WriteLine(text);
        }
    }
}
