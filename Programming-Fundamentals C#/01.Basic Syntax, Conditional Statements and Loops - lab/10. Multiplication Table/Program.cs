using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = 0;

            for (int i = 1; i <= 10; i++)
            {
                times++;
                int value = num * times;
                Console.WriteLine($"{num} X {times} = {value}");
            }
        }
    }
}
