using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            int times = num2;
            int value = 0;

            if (num2 <= 10)
            {
                for (int i = num2; i <= 10; i++)
                {
                    value = num1 * times;
                    Console.WriteLine($"{num1} X {times} = {value}");
                    times++;
                }
            }
            else
            {
                value = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {value}");
            }
            
        }
    }
}
