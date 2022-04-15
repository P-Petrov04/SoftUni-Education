using System;

namespace _1._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long operation1 =(long)num1 + num2;
            long operation2 = operation1 / num3;
            long operation3 = operation2 * num4;

            Console.WriteLine(operation3);
        }
    }
}
