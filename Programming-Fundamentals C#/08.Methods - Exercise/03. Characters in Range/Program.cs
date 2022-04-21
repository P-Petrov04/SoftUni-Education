using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char chStart = char.Parse(Console.ReadLine());
            char chEnd = char.Parse(Console.ReadLine());

            char[] charArray = new char[2] { chStart, chEnd };
            SwapChStartAndCharEnd(charArray, chStart, chEnd);
            PrintCharsFromStartToEnd(charArray, chStart, chEnd);
            
        }

        static char[] SwapChStartAndCharEnd (char[] chArray,char ch1, char ch2)
        {
            int valueCh1 = ch1;
            int valueCh2 = ch2;

            if (valueCh1 > valueCh2)
            {
                chArray[0] = ch2;
                chArray[1] = ch1;
            }

            return chArray;
        }

        static void PrintCharsFromStartToEnd (char[] chArray, char ch1, char ch2)
        {
            for (int i = chArray[0] + 1; i < chArray[1]; i++)
            {
                char currentCh = (char)i;
                Console.Write($"{currentCh} ");
            }
        }
       
    }
}
