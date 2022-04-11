using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = i * 2 - 1;
                sum += num;
                Console.WriteLine(num);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
