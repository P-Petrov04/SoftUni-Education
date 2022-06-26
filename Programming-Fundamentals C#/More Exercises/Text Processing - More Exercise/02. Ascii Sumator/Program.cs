using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            string randomStr = Console.ReadLine();

            int sum = 0;
            List<char> validCh = randomStr.Where(ch => (int)ch > firstCh && (int)ch < secondCh).ToList();
            foreach (char ch in validCh)
            {
                sum += (int)ch;
            }
            Console.WriteLine(sum);
        }
    }
}
